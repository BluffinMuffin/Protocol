using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes.Options
{
    /// <summary>
    ///  
    /// </summary>
    public class GameMessageOptionsStudBringIn : GameMessageOption
    {
        /// <summary>
        /// 
        /// </summary>
        public override GameMessageEnum OptionType => GameMessageEnum.StudBringIn;

        /// <summary>
        /// The cards that are responsible for the Lowest Hand
        /// </summary>
        [ExampleValues(1, "5s")]
        public string[] Cards { get; set; }

        /// <summary>
        /// The hand that is responsible for the lowest hand
        /// </summary>
        [ExampleValue(PokerHandEnum.HighCard)]
        public PokerHandEnum LowestHand { get; set; }

        /// <summary>
        /// The name of the player that has the lowest hand.
        /// </summary>
        [ExampleValue("SpongeBob")]
        public string PlayerName { get; set; }

        /// <summary>
        /// Function to build the message
        /// </summary>
        public override string BuildMessage() => $"{PlayerName} must put the bring-in since he got the lowest Hand ({LowestHand} {string.Join(",", Cards)})";
    }
}
