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
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(T));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var instance = ObtainCustomObject(jObject);
            if (instance != null)
                serializer.Populate(jObject.CreateReader(), instance);
            return instance;
        }

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
