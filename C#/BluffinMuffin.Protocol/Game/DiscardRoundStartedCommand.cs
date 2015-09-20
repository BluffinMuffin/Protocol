using BluffinMuffin.Protocol.DataTypes.Attributes;

namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// This command is issued by the server when a discard round is starting. All Player must send a PlayerDiscardActionCommand that fits the discard round limitations.
    /// </summary>
    public class DiscardRoundStartedCommand : AbstractGameCommand
    {
        /// <summary>
        /// The minimum number of cards that a player must discard
        /// </summary>
        [ExampleValue(0)]
        public int MinimumCardsToDiscard { get; set; }
        /// <summary>
        /// The maximum number of cards that a player can discard
        /// </summary>
        [ExampleValue(5)]
        public int MaximumCardsToDiscard { get; set; }
    }
}
