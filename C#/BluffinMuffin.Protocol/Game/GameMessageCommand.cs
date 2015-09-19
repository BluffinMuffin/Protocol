using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Enums;
using BluffinMuffin.Protocol.DataTypes.Json;
using BluffinMuffin.Protocol.DataTypes.Options;
using Newtonsoft.Json;

namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// This command is there to inform players of something. This is for additionnal information, ignoring this message should not change anything to the game.
    /// </summary>
    public class GameMessageCommand : AbstractGameCommand
    {
        /// <summary>
        /// The text message
        /// </summary>
        public string Message => Info.BuildMessage();

        /// <summary>
        /// The specific information of the message
        /// </summary>
        [ExampleValue(typeof(GameMessageOptionPlayerJoined))]
        [JsonConverter(typeof(OptionJsonConverter<GameMessageOption, GameMessageEnum>))]
        [JsonProperty(Order = 100)]
        public GameMessageOption Info { get; set; }
    }
}
