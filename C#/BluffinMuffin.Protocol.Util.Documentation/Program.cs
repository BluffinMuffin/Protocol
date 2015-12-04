using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using BluffinMuffin.Protocol.DataTypes;
using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BluffinMuffin.Protocol.Util.Documentation
{
    internal class Program
    {
        private static readonly Dictionary<Type, string> m_Aliases =
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

        private static readonly Dictionary<string, string> m_Summaries = new Dictionary<string, string>();

        public static void LoadDocOfAssembly(Type exampleType)
        {
            var xmlroot = XElement.Load(Assembly.GetAssembly(exampleType).Location.Replace(".dll", ".xml"));
            var element = xmlroot.Element("members");
            if (element != null)
                foreach (XElement classTag in element.Elements("member"))
                {
                    string name = classTag.Attribute("name").Value;
                    var xElement = classTag.Element("summary");
                    string summary = xElement?.Value;
                    if (!string.IsNullOrEmpty(summary) && !m_Summaries.ContainsKey(name))
                        m_Summaries.Add(name, summary);
                }
        }

        private static void Main()
        {
            LoadDocOfAssembly(typeof(AbstractCommand));
            LoadDocOfAssembly(typeof(TupleTable));

            GenereDocForCommands();
            GenereDocForOptions();
        }

        private static void WriteSummary(Type t, StreamWriter sw)
        {
            string fullname = t.FullName;
            var name = "T:" + fullname;
            string summary = m_Summaries.ContainsKey(name) ? m_Summaries[name] : t.FullName;
            foreach (var line in summary.Trim().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
            {
                sw.WriteLine();
                sw.WriteLine(line.Replace("]({", "](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/main/Documentation/").Replace("})", ".md)").Trim());
            }
        }

        private static void GenereDocForOptions()
        {
            var types = Assembly.GetAssembly(typeof(TupleTable)).GetTypes().Where(t => t.IsClass && t.IsAbstract && t.GetInterfaces().Select(x => x.Name).Contains(typeof(IOption< >).Name)).ToArray();

            foreach (Type t in types)
            {
                string fullname = t.FullName;
                string path = Path.Combine(GetWorkingDirectory(), @"..\..\..\..\Documentation", fullname + ".md");
                FileInfo info = new FileInfo(path);
                if (info.Exists)
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

        private static string GetWorkingDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        private static void GenereDocForCommands()
        {
            var types = Assembly.GetAssembly(typeof(AbstractCommand)).GetTypes().Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(AbstractCommand)) && !t.GetInterfaces().Contains(typeof(IResponse))).ToArray();

            foreach (Type t in types)
            {
                string fullname = t.FullName;
                string path = Path.Combine(GetWorkingDirectory(), @"..\..\..\..\Documentation", fullname + ".md");
                FileInfo info = new FileInfo(path);
                if (info.Exists)
                    info.IsReadOnly = false;
                var sw = new StreamWriter(path);
                string commandName = t.Name;
                if (t.Namespace != null)
                {
                    string title = "# " + t.Namespace.Replace("BluffinMuffin.Protocol.", "").Replace("BluffinMuffin.Protocol", "General").Replace(".", " ") + " : " + commandName.Replace("Command", "");
                    sw.WriteLine(title);
                }
                WriteSummary(t, sw);
                if (File.Exists(Path.Combine(GetWorkingDirectory(), @"..\..\..\..\Documentation\Sequences\", fullname + ".png")))
                {
                    sw.WriteLine();
                    sw.WriteLine("<p align=center><img src=\"https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/main/Documentation/Sequences/{0}.png\" alt=\"Sequence Diagram\"></p>", fullname);
                }
                if (File.Exists(Path.Combine(GetWorkingDirectory(), @"..\..\..\..\Documentation\Activities\", fullname + ".png")))
                {
                    sw.WriteLine();
                    sw.WriteLine("<p align=center><img src=\"https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/main/Documentation/Activities/{0}.png\" alt=\"Activity Diagram\"></p>", fullname);
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
                    string summary = m_Summaries.ContainsKey(name) ? m_Summaries[name] : string.Empty;
                    while (string.IsNullOrEmpty(summary) && sType.BaseType != null && sType.BaseType != sType)
                    {
                        sType = sType.BaseType;
                        string full = sType.FullName;
                        if (full.Contains("["))
                            full = full.Remove(full.IndexOf('['));
                        name = "P:" + full + "." + p.Name;
                        summary = m_Summaries.ContainsKey(name) ? m_Summaries[name] : string.Empty;
                    }
                    string desc = string.Join(" ", summary.Trim().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim())).Trim();
                    if (!string.IsNullOrEmpty(desc))
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
            else if (t.IsGenericType && (t.GetGenericTypeDefinition() == typeof(List<>)))
            {
                writer.WriteValue("array");
                writer.WritePropertyName("items");
                writer.WriteStartObject();
                WriteType(writer, t.GetGenericArguments()[0]);
                writer.WriteEndObject();
            }
            else if (t.IsPrimitive || t == typeof(string))
                writer.WriteValue(m_Aliases[t]);
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
            foreach(var it in Enum.GetNames(propertyType))
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
                            var value = ex.Value as Type;
                            p.SetValue(c, value != null ? Remplir(value) : p.GetCustomAttribute<ExampleValueAttribute>().Value);
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
                                    if (et.IsClass && et != typeof(string))
                                    {
                                        var types = exs.Values[i].Select(x => x.GetType()).ToArray();
                                        List<KeyValuePair<Type, object>> kvps = new List<KeyValuePair<Type, object>>();
                                        for(int j = 0; j < exs.Values[0].Length; ++i)
                                            kvps.Add(new KeyValuePair<Type, object>(types[j],exs.Values[i][j]));
                                        lst.Add(Remplir(et,kvps.ToArray()));
                                    }
                                    else
                                    {
                                        lst.Add(exs.Values[i][0]);
                                    }
                                }
                                p.SetValue(c, array);
                                
                            }
                            else
                            {

                                object array = Activator.CreateInstance(p.PropertyType, exs.NbObjects); // Length 1
                                IList lst = (IList)array;

                                for (int i = 0; i < exs.NbObjects; ++i)
                                {
                                    var et = p.PropertyType.GetElementType();
                                    if (et.IsClass && et != typeof(string))
                                    {
                                        var types = exs.Values[i].Select(x => x.GetType()).ToArray();
                                        List<KeyValuePair<Type, object>> kvps = new List<KeyValuePair<Type, object>>();
                                        for (int j = 0; j < exs.Values[i].Length; ++j)
                                            kvps.Add(new KeyValuePair<Type, object>(types[j], exs.Values[i][j]));
                                        lst[i] = Remplir(et, kvps.ToArray());
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
                        // ignored
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
