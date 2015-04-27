using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// The server is sharing new information about the money in the pockets of a player.
    /// </summary>
    public class PlayerMoneyChangedCommand : AbstractGameCommand
    {
        /// <summary>
        /// The position on the table where is sitting the player.
        /// </summary>
        [ExampleValue(7)]
        public int PlayerPos { get; set; }

        /// <summary>
        /// The unplayed amount of money that the player have.
        /// </summary>
        [ExampleValue(4200)]
        public int PlayerMoney { get; set; }
    }
}
