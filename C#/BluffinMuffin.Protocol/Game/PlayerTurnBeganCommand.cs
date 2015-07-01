using BluffinMuffin.Protocol.DataTypes.Attributes;

namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// The server sends this command to indicated that it's time for a specific player to play.
    /// </summary>
    public class PlayerTurnBeganCommand : AbstractGameCommand
    {
        /// <summary>
        /// The position on the table where is sitting the player that needs to play
        /// </summary>
        [ExampleValue(7)]
        public int NoSeat { get; set; }

        /// <summary>
        /// The minimum amount needed to raise. A raise must be at least the size of the largest previous bet or raise of the current betting round.
        /// </summary>
        [ExampleValue(6)]
        public int MinimumRaiseAmount { get; set; }
    }
}
