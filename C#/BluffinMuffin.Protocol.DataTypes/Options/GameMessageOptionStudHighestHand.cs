using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes.Options
{
    /// <summary>
    ///  
    /// </summary>
    public class GameMessageOptionsStudHighestHand : GameMessageOption
    {
        /// <summary>
        /// 
        /// </summary>
        public override GameMessageEnum OptionType => GameMessageEnum.StudHighestHand;

        /// <summary>
        /// The cards that are responsible for the Highest Hand
        /// </summary>
        [ExampleValues(2, "As", "Ah")]
        public string[] Cards { get; set; }

        /// <summary>
        /// The hand that is responsible for the Highest hand
        /// </summary>
        [ExampleValue(PokerHandEnum.OnePair)]
        public PokerHandEnum HighestHand { get; set; }

        /// <summary>
        /// The name of the player that has the Highest hand.
        /// </summary>
        [ExampleValue("SpongeBob")]
        public string PlayerName { get; set; }

        /// <summary>
        /// Function to build the message
        /// </summary>
        public override string BuildMessage() => $"{PlayerName} must talk first since he got the highest Hand ({HighestHand} {string.Join(",", Cards)})";
    }
}
