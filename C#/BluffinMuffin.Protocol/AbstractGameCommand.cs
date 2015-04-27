using Com.Ericmas001.Net.Protocol;
using Newtonsoft.Json;

namespace BluffinMuffin.Protocol
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstractGameCommand : AbstractBluffinCommand, IGameCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public override BluffinCommandEnum CommandType
        {
            get { return BluffinCommandEnum.Game; }
        }

        /// <summary>
        /// The id of the table where this command needs to go
        /// </summary>
        [ExampleValue(42)]
        [JsonProperty(Order = -42)]
        public int TableId { get; set; }
    }
}
