using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// This command is sent after the showdown to inform clients that some money has been won by some player
    /// </summary>
    public class PlayerWonPotCommand : AbstractGameCommand
    {
        /// <summary>
        /// The position on the table where is sitting the player that won something
        /// </summary>
        [ExampleValue(7)]
        public int PlayerPos { get; set; }

        /// <summary>
        /// The Id of the pot that was won by the player
        /// </summary>
        [ExampleValue(0)]
        public int PotId { get; set; }

        /// <summary>
        /// The amount of money that was won by the player (Could be a fraction of the pot if there was a split.
        /// </summary>
        [ExampleValue(420)]
        public int Shared { get; set; }

        /// <summary>
        /// The total amount of money in the pockets of the player after winning this money
        /// </summary>
        [ExampleValue(4200)]
        public int PlayerMoney { get; set; }
    }
}
