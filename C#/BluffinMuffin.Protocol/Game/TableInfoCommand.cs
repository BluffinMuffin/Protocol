using System.Collections.Generic;
using BluffinMuffin.Protocol.DataTypes;
using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// Sends all the information about the current state of the table, to put everybody on the same page.
    /// </summary>
    public class TableInfoCommand : AbstractGameCommand
    {
        /// <summary>
        /// Parameters of the poker table
        /// </summary>
        public TableParams Params { get; set; }


        /// <summary>
        /// The total amount of money currently played in this game. This include the money in the center, and the money played in front of each player.
        /// </summary>
        [ExampleValue(42000)]
        public int TotalPotAmount { get; set; }

        /// <summary>
        /// All the pots on the table. Usually only one, but can have more if some players are all-in.
        /// </summary>
        [ExampleValues(2, 4200, 420)]
        public List<int> PotsAmount { get; set; }

        /// <summary>
        /// All the card ids currently visible on the board (Preflop: empty, flop: 3 cars, turn: 4 cards, river: 5 cards) 
        /// </summary>
        [ExampleValues(3, "2s", "Kh", "5d")]
        public string[] BoardCards { get; set; }

        /// <summary>
        /// The information about every seats around the table
        /// </summary>
        [ExampleValue(1)]
        public List<SeatInfo> Seats { get; set; }

        /// <summary>
        /// Informs the client if the game is currently in the playing state, or not.
        /// </summary>
        [ExampleValue(true)]
        public bool GameHasStarted { get; set; }
    }
}
