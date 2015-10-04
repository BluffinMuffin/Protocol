using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BluffinMuffin.Protocol.DataTypes.Json
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractCustomJsonConverter<T> : JsonConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(T));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var instance = ObtainCustomObject(jObject);
            if (instance != null)
                serializer.Populate(jObject.CreateReader(), instance);
            return instance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jObject"></param>
        /// <returns></returns>
        public abstract T ObtainCustomObject(JObject jObject);
    }
}
