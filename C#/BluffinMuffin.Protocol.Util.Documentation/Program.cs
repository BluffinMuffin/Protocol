using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;

namespace BluffinMuffin.Protocol.Util.Documentation
{
    internal class Program
    {
        private static readonly Dictionary<Type, string> Aliases =
            new Dictionary<Type, string>()
            {
                {typeof (byte), "byte"},
                {typeof (sbyte), "sbyte"},
                {typeof (short), "short"},
                {typeof (ushort), "ushort"},
                {typeof (int), "int"},
                {typeof (uint), "uint"},
                {typeof (long), "long"},
                {typeof (ulong), "ulong"},
                {typeof (float), "float"},
                {typeof (double), "double"},
                {typeof (decimal), "decimal"},
                {typeof (object), "object"},
                {typeof (bool), "bool"},
                {typeof (char), "char"},
                {typeof (string), "string"},
                {typeof (void), "void"}
            };

        private static void Main(string[] args)
        {
            var types = Assembly.GetAssembly(typeof (AbstractBluffinCommand)).GetTypes().Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof (AbstractBluffinCommand)) && !t.GetInterfaces().Contains(typeof (IResponse))).ToArray();
            var xmlroot = XElement.Load(Assembly.GetAssembly(typeof (AbstractBluffinCommand)).Location.Replace(".dll", ".xml"));
            foreach (Type t in types)
            {
                string fullname = t.FullName;
                var classTag = xmlroot.Element("members").Elements("member").FirstOrDefault(x => x.Attribute("name").Value == ("T:" + fullname));
                string summary = classTag == null ? fullname : classTag.Element("summary") == null ? fullname : classTag.Element("summary").Value;
                var sw = new StreamWriter(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fullname + ".md"));
                string commandName = t.Name;
                string title = "# " + t.Namespace.Replace("BluffinMuffin.Protocol.", "").Replace("BluffinMuffin.Protocol", "General").Replace(".", " ") + " : " + commandName.Replace("Command", "");
                sw.WriteLine(title);
                foreach (var line in summary.Trim().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
                {
                    sw.WriteLine();
                    sw.WriteLine(line.Trim());
                }
                sw.WriteLine();
                sw.WriteLine("## {0}", commandName);
                sw.WriteLine();
                GenerateSchema(t, sw, xmlroot);
                GenerateExamples(t, sw, xmlroot);
                Type responseTypeIntefaceType = t.GetInterfaces().FirstOrDefault(x => x.Name == typeof (ICommandWithResponse<>).Name);
                if (responseTypeIntefaceType != null)
                {
                    Type rt = responseTypeIntefaceType.GetGenericArguments()[0];
                    string responseName = t.Name;
                    sw.WriteLine("## {0}", responseName);
                    sw.WriteLine();
                    GenerateSchema(rt, sw, xmlroot);
                    GenerateExamples(rt, sw, xmlroot);
                }
                sw.Close();
            }
        }

        private static void GenerateSchema(Type t, StreamWriter sw, XElement xmlroot)
        {
            sw.WriteLine("### Command Schema");
            sw.WriteLine();
            sw.WriteLine("```json");
            JsonWriter writer = new JsonTextWriter(sw);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("title");
            writer.WriteValue("Schema for " + t.Name);
            writer.WritePropertyName("type");
            writer.WriteValue("object");
            WriteProperties(t, writer, xmlroot);
            writer.WriteEndObject();
            sw.WriteLine("```");
            sw.WriteLine();
        }

        private static void WriteProperties(Type type, JsonWriter writer, XElement xmlroot)
        {
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            foreach (var p in type.GetProperties(BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance).Where(x => x.GetCustomAttribute<JsonIgnoreAttribute>() == null).OrderBy(x => x.GetCustomAttribute<JsonPropertyAttribute>() == null ? 0 : x.GetCustomAttribute<JsonPropertyAttribute>().Order).ThenBy(x => x.Name))
            {
                writer.WritePropertyName(p.Name);
                writer.WriteStartObject();
                if (p.Name == "CommandName")
                {
                    writer.WritePropertyName("description");
                    writer.WriteValue("Always contains '"+type.Name+"' to distinguish the command from others.");
                }
                else
                {
                    var propTag = xmlroot.Element("members").Elements("member").FirstOrDefault(x => x.Attribute("name").Value == ("P:" + type.FullName + "." + p.Name));
                    if (propTag != null)
                    {
                        string summary = propTag == null ? String.Empty : propTag.Element("summary") == null ? String.Empty : propTag.Element("summary").Value;
                        string desc = String.Join(" ", summary.Trim().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim())).Trim();
                        if (!String.IsNullOrEmpty(desc))
                        {
                            writer.WritePropertyName("description");
                            writer.WriteValue(desc);
                        }
                    }
                }
                writer.WritePropertyName("type");
                if (p.PropertyType.IsPrimitive || p.PropertyType == typeof (string))
                    writer.WriteValue(Aliases[p.PropertyType]);
                else
                {
                    writer.WriteValue("object");
                    WriteProperties(p.PropertyType, writer, xmlroot);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        private static void GenerateExamples(Type t, StreamWriter sw, XElement xmlroot)
        {
            sw.WriteLine("### Example");
            sw.WriteLine();
        }
    }
}
