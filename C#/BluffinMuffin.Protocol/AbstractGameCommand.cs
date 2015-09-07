using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.Enums;
using Newtonsoft.Json;

namespace BluffinMuffin.Protocol
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstractGameCommand : AbstractCommand, IGameCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public override BluffinCommandEnum CommandType => BluffinCommandEnum.Game;

        /// <summary>
        /// The id of the table where this command needs to go
        /// </summary>
        [ExampleValue(42)]
        [JsonProperty(Order = -42)]
        public int TableId { get; set; }
    }
}
