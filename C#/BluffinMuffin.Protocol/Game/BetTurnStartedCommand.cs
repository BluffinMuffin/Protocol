using System.Collections.Generic;
using BluffinMuffin.Protocol.DataTypes.Enums;
using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// This command is issued by the server when a betting round is ending. For example, when the 3 first cards are shown, it's the beginning of the flop.
    /// </summary>
    public class BetTurnStartedCommand : AbstractGameCommand
    {
        /// <summary>
        /// The round that is ending
        /// </summary>
        [ExampleValue(RoundTypeEnum.Flop)]
        public RoundTypeEnum Round { get; set; }
        /// <summary>
        /// All the card ids currently visible on the board (Preflop: empty, flop: 3 cards, turn: 4 cards, river: 5 cards) 
        /// </summary>
        [ExampleValues(3, "2s", "Kh", "5d")]
        public string[] Cards { get; set; }
    }
}
