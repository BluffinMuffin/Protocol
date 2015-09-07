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
        /// The cards in hand that are currently facing up (visible to other players).
        /// </summary>
        [ExampleValues(2, "2s", "Ah")]
        public string[] FaceUpCards { get; set; }

        /// <summary>
        /// The cards in hand that are currently facing down (hidden to other players).
        /// </summary>
        [ExampleValues(2, "??", "??")]
        public string[] FaceDownCards { get; set; }

        /// <summary>
        /// The state of the player.
        /// </summary>
        [ExampleValue(PlayerStateEnum.Playing)]
        public PlayerStateEnum PlayerState { get; set; }
    }
}
