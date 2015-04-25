using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BluffinMuffin.Protocol.DataTypes;
using Com.Ericmas001.Net.Protocol;
using Com.Ericmas001.Net.Protocol.JSON;
using Com.Ericmas001.Net.Protocol.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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

        private static readonly Dictionary<string, string> Summaries = new Dictionary<string, string>();

        public static void LoadDocOfAssembly(Type exampleType)
        {
            var xmlroot = XElement.Load(Assembly.GetAssembly(exampleType).Location.Replace(".dll", ".xml"));
            foreach (XElement classTag in xmlroot.Element("members").Elements("member"))
            {
                string name = classTag.Attribute("name").Value;
                string summary = classTag.Element("summary") == null ? null : classTag.Element("summary").Value;
                if (!String.IsNullOrEmpty(summary) && !Summaries.ContainsKey(name))
                    Summaries.Add(name, summary);
            }
        }

        private static void Main(string[] args)
        {
            LoadDocOfAssembly(typeof(AbstractBluffinCommand));
            LoadDocOfAssembly(typeof(TupleTable));

            GenereDocForCommands();
            GenereDocForOptions();
        }

        private static void WriteSummary(Type t, StreamWriter sw)
        {
            string fullname = t.FullName;
            var name = "T:" + fullname;
            string summary = Summaries.ContainsKey(name) ? Summaries[name] : t.FullName;
            foreach (var line in summary.Trim().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
            {
                sw.WriteLine();
                sw.WriteLine(line.Replace("]({", "](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/").Replace("})", ".md)").Trim());
            }
        }

        private static void GenereDocForOptions()
        {
            var types = Assembly.GetAssembly(typeof(TupleTable)).GetTypes().Where(t => t.IsClass && t.IsAbstract && t.GetInterfaces().Select(x => x.Name).Contains(typeof(IOption< >).Name)).ToArray();

            foreach (Type t in types)
            {
                string fullname = t.FullName;
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\..\..\Documentation", fullname + ".md");
                FileInfo info = new FileInfo(path);
                if(info.Exists)
                    info.IsReadOnly = false;
                var sw = new StreamWriter(path);
                sw.WriteLine("# " + t.Name);
                WriteSummary(t, sw);
                sw.WriteLine();
                GenerateSchema(t, sw);

                var subtypes = Assembly.GetAssembly(t).GetTypes().Where(st => st.IsClass && !st.IsAbstract && st.IsSubclassOf(t)).ToArray();
                foreach (Type st in subtypes)
                {
                    sw.WriteLine("## {0}", st.Name);
                    WriteSummary(st, sw);
                    sw.WriteLine();
                    GenerateSchema(st, sw);
                    GenerateExamples(st, sw);
                    
                }
                sw.Close();
            }
        }

        private static void GenereDocForCommands()
        {
            var types = Assembly.GetAssembly(typeof(AbstractBluffinCommand)).GetTypes().Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(AbstractBluffinCommand)) && !t.GetInterfaces().Contains(typeof(IResponse))).ToArray();

            foreach (Type t in types)
            {
                string fullname = t.FullName;
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\..\..\Documentation", fullname + ".md");
                FileInfo info = new FileInfo(path);
                info.IsReadOnly = false;
                var sw = new StreamWriter(path);
                string commandName = t.Name;
                string title = "# " + t.Namespace.Replace("BluffinMuffin.Protocol.", "").Replace("BluffinMuffin.Protocol", "General").Replace(".", " ") + " : " + commandName.Replace("Command", "");
                sw.WriteLine(title);
                WriteSummary(t, sw);
                if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\..\..\Documentation\Sequences\", fullname + ".png")))
                {
                    sw.WriteLine();
                    sw.WriteLine("<p align=center><img src=\"https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/{0}.png\" alt=\"Sequence Diagram\"></p>", fullname);
                }
                if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\..\..\Documentation\Activities\", fullname + ".png")))
                {
                    sw.WriteLine();
                    sw.WriteLine("<p align=center><img src=\"https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/{0}.png\" alt=\"Activity Diagram\"></p>", fullname);
                }
                sw.WriteLine();
                sw.WriteLine("## {0}", commandName);
                sw.WriteLine();
                GenerateSchema(t, sw);
                object c = GenerateExamples(t, sw);
                Type responseTypeIntefaceType = t.GetInterfaces().FirstOrDefault(x => x.Name == typeof(ICommandWithResponse<>).Name);
                if (responseTypeIntefaceType != null)
                {
                    Type rt = responseTypeIntefaceType.GetGenericArguments()[0];
                    string responseName = rt.Name;
                    sw.WriteLine("## {0}", responseName);
                    sw.WriteLine();
                    GenerateSchema(rt, sw);
                    GenerateExamples(rt, sw, c);
                }
                sw.Close();
            }
        }

        private static void GenerateSchema(Type t, StreamWriter sw)
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
            writer.WriteValue(t.FullName);
            WriteProperties(t, writer);
            writer.WriteEndObject();
            sw.WriteLine();
            sw.WriteLine("```");
            sw.WriteLine();
        }

        private static void WriteProperties(Type type, JsonWriter writer)
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
                    var name = "P:" + type.FullName + "." + p.Name;
                    var sType = type;
                    string summary = Summaries.ContainsKey(name) ? Summaries[name] : String.Empty;
                    while (string.IsNullOrEmpty(summary) && sType.BaseType != null && sType.BaseType != sType)
                    {
                        sType = sType.BaseType;
                        string full = sType.FullName;
                        if (full.Contains("["))
                            full = full.Remove(full.IndexOf('['));
                        name = "P:" + full + "." + p.Name;
                        summary = Summaries.ContainsKey(name) ? Summaries[name] : String.Empty;
                    }
                    string desc = String.Join(" ", summary.Trim().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim())).Trim();
                    if (!String.IsNullOrEmpty(desc))
                    {
                        writer.WritePropertyName("description");
                        writer.WriteValue(desc);
                    }
                }
                WriteType(writer,p.PropertyType);
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        private static void WriteType(JsonWriter writer, Type t)
        {
            writer.WritePropertyName("type");
            if (t.IsArray)
            {
                writer.WriteValue("array");
                writer.WritePropertyName("items");
                writer.WriteStartObject();
                WriteType(writer, t.GetElementType());
                writer.WriteEndObject();
            }
            else if (t.IsPrimitive || t == typeof(string))
                writer.WriteValue(Aliases[t]);
            else
            {
                writer.WriteValue(t.FullName);
                if (t.IsEnum)
                    WriteEnum(t, writer);
                else
                    WriteProperties(t, writer);
            }
        }

        private static void WriteEnum(Type propertyType, JsonWriter writer)
        {
            writer.WritePropertyName("enum");
            writer.WriteStartArray();
            foreach(var it in Enum.GetNames(propertyType).OrderBy(x => x))
                writer.WriteValue(it);
            writer.WriteEndArray();
        }

        public static object Remplir(Type type, params KeyValuePair<Type,object>[] ctorParms )
        {
            var ctor = type.GetConstructor(ctorParms.Select(x => x.Key).ToArray());
            if (ctor != null)
            {
                object c = ctor.Invoke(ctorParms.Select(x => x.Value).ToArray());
                foreach (var p in type.GetProperties(BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance).Where(x => x.CanWrite && x.GetCustomAttribute<JsonIgnoreAttribute>() == null))
                {
                    try
                    {
                        var ex = p.GetCustomAttribute<ExampleValueAttribute>();
                        var exs = p.GetCustomAttribute<ExampleValuesAttribute>();
                        if (ex != null)
                        {
                            if (ex.Value is Type)
                                p.SetValue(c, ((Type)ex.Value).GetConstructor(Type.EmptyTypes).Invoke(new object[] { }));
                            else
                                p.SetValue(c, p.GetCustomAttribute<ExampleValueAttribute>().Value);
                        }
                        else if (exs != null)
                        {
                            if (p.PropertyType.IsGenericType && (p.PropertyType.GetGenericTypeDefinition() == typeof (List<>)))
                            {

                                object array = Activator.CreateInstance(p.PropertyType); // Length 1
                                IList lst = (IList)array;

                                for (int i = 0; i < exs.NbObjects; ++i)
                                {
                                    var et = p.PropertyType.GetGenericArguments()[0];
                                    if (et.IsClass)
                                    {
                                        var types = exs.Values[i].Select(x => x.GetType()).ToArray();
                                        var ct = et.GetConstructor(types);

                                        lst.Add(ct.Invoke(exs.Values[i]));
                                    }
                                    else
                                    {
                                        lst.Add(exs.Values[0]);
                                    }
                                }
                                p.SetValue(c, array);
                                
                            }
                            else
                            {

                                object array = Activator.CreateInstance(p.PropertyType, new object[] { exs.NbObjects }); // Length 1
                                IList lst = (IList)array;

                                for (int i = 0; i < exs.NbObjects; ++i)
                                {
                                    var et = p.PropertyType.GetElementType();
                                    if (et.IsClass)
                                    {
                                        var types = exs.Values[i].Select(x => x.GetType()).ToArray();
                                        var ct = et.GetConstructor(types);

                                        lst[i] = ct.Invoke(exs.Values[i]);
                                    }
                                    else
                                    {
                                        lst[i] = exs.Values[i][0];
                                    }
                                }
                                p.SetValue(c, array);
                                
                            }
                        }
                        else if (p.PropertyType.IsClass && p.PropertyType != typeof(string) && !p.PropertyType.IsArray)
                            p.SetValue(c, Remplir(p.PropertyType));
                    }
                    catch (Exception)
                    {

                    }
                }
                return c;
            }
            return null;
        }

        private static object GenerateExamples(Type type, StreamWriter sw, object o = null)
        {
            sw.WriteLine("### Example");
            sw.WriteLine();
            sw.WriteLine("```json");

            object c = o == null ? Remplir(type) : Remplir(type, new KeyValuePair<Type, object>(o.GetType(), o));

            sw.WriteLine(JsonConvert.SerializeObject(c, Formatting.Indented, new StringEnumConverter()));
            sw.WriteLine("```");
            sw.WriteLine();

            return c;
        }
    }
}
