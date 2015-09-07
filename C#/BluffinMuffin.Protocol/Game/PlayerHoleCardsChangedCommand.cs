using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// This command is send by the server to inform everybody that the cards of a player just changed.
    /// This is used to inform a player of the cards he just got dealed, to inform other players that some cards has been dealt to a player, or to show cards to everybody at showdown.
    /// </summary>
    public class PlayerHoleCardsChangedCommand : AbstractGameCommand
    {
        /// <summary>
        /// The position on the table where is sitting the player with the cards.
        /// </summary>
        [ExampleValue(7)]
        public int NoSeat { get; set; }

        /// <summary>
        /// The visible cards currently in the hands of the player
        /// </summary>
        [ExampleValues(2, "4h", "Qs")]
        public string[] Cards { get; set; }

        /// <summary>
        /// How many cards in the hand of the player that are invisible
        /// </summary>
        [ExampleValue(3)]
        public int NbHiddenCards { get; set; }

        /// <summary>
        /// The state of the player.
        /// </summary>
        [ExampleValue(PlayerStateEnum.Playing)]
        public PlayerStateEnum PlayerState { get; set; }
    }
}
