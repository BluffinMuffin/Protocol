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
        /// The amount needed to call. It's the minimum to play if you don't want to fold.
        /// </summary>
        [ExampleValue(21)]
        public int AmountNeeded { get; set; }

        /// <summary>
        /// Usually True. Indicates if the player have the option to Fold. It's false when it's the bring-in.
        /// </summary>
        [ExampleValue(true)]
        public bool CanFold { get; set; }

        /// <summary>
        /// The minimum amount needed to raise. A raise must be at least the size of the largest previous bet or raise of the current betting round. To raise, the player have to send at least AmountNeeded+MinimumRaiseAmount.
        /// </summary>
        [ExampleValue(42)]
        public int MinimumRaiseAmount { get; set; }

        /// <summary>
        /// The maximum amount somebody can raise. Total, the player can put AmountNeeded+MaximumRaiseAmount. When No Maximum, this is set to int.MaxValue
        /// </summary>
        [ExampleValue(4200)]
        public int MaximumRaiseAmount { get; set; }
    }
}
