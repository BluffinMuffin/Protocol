using BluffinMuffin.Protocol.DataTypes.Attributes;
using Newtonsoft.Json;

namespace BluffinMuffin.Protocol
{
    public abstract class AbstractCommand
    {
        /// <summary>
        /// Always contains '{CommandName}' to distinguish the command from others."
        /// </summary>
        [JsonProperty(Order = -100)]
        [ExampleValue("{CommandName}")]
        public string CommandName { get { return GetType().Name; } }

        public abstract string Encode();
    }
}
