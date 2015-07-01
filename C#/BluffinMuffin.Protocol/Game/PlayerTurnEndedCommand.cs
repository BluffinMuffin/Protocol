using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// Server informs all the clients that a player has taken action.
    /// </summary>
    public class PlayerTurnEndedCommand : AbstractGameCommand
    {
        /// <summary>
        /// The position on the table where is sitting the player that needs to play
        /// </summary>
        [ExampleValue(7)]
        public int NoSeat { get; set; }
        /// <summary>
        /// The total amount of money a player have bet since the beginning of the round. 
        /// </summary>
        [ExampleValue(420)]
        public int TotalPlayedMoneyAmount { get; set; }
        /// <summary>
        /// The total amount of money a player have that has not been played.
        /// </summary>
        [ExampleValue(4200)]
        public int TotalSafeMoneyAmount { get; set; }
        /// <summary>
        /// The total amount of money currently played in this game. This include the money in the center, and the money played in front of each player.
        /// </summary>
        [ExampleValue(42000)]
        public int TotalPot { get; set; }
        /// <summary>
        /// The type of action that was taken by the player
        /// </summary>
        [ExampleValue(GameActionEnum.Call)]
        public GameActionEnum ActionTakenType { get; set; }
        /// <summary>
        /// The amount of money that the player has put for this single action
        /// </summary>
        [ExampleValue(42)]
        public int ActionTakenAmount { get; set; }
        /// <summary>
        /// The current state of the player that just played
        /// </summary>
        [ExampleValue(PlayerStateEnum.Playing)]
        public PlayerStateEnum PlayerState { get; set; }
    }
}
