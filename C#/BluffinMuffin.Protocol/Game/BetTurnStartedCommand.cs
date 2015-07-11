using System;
using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// This command is issued by the server when a betting round is starting. For example, when the 3 first cards are shown, it's the beginning of the flop.
    /// </summary>
    public class BetTurnStartedCommand : AbstractGameCommand
    {
        /// <summary>
        /// OBSOLETE: The round that is starting
        /// </summary>
        [ExampleValue(RoundTypeEnum.Flop)]
        [Obsolete("Use BettingRoundId instead")]
        public RoundTypeEnum Round { get; set; }
        /// <summary>
        /// The id of the betting round that is starting, starting at 1. For texas hold'em, Preflop=1, Flop=2, Turn=3, River=4
        /// </summary>
        [ExampleValue(1)]
        public int BettingRoundId { get; set; }
        /// <summary>
        /// All the card ids currently visible on the board (Preflop: empty, flop: 3 cards, turn: 4 cards, river: 5 cards) 
        /// </summary>
        [ExampleValues(3, "2s", "Kh", "5d")]
        public string[] Cards { get; set; }
    }
}
