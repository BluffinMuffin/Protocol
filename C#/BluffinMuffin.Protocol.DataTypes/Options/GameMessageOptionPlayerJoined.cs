using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes.Options
{
    /// <summary>
    ///  
    /// </summary>
    public class GameMessageOptionPlayerJoined : GameMessageOption
    {
        /// <summary>
        /// 
        /// </summary>
        public override GameMessageEnum OptionType => GameMessageEnum.PlayerJoined;

        /// <summary>
        /// The name of the player that just joined the table.
        /// </summary>
        [ExampleValue("SpongeBob")]
        public string PlayerName { get; set; }

        /// <summary>
        /// Function to build the message
        /// </summary>
        public override string BuildMessage() => $"{PlayerName} just joined the table";
    }
}
