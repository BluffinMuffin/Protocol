using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// The client is telling the server that he wants to sit at a specific seat
    /// </summary>
    public class PlayerSitInCommand : AbstractGameCommand, ICommandWithResponse<PlayerSitInResponse>
    {
        /// <summary>
        /// The seat where the player wants to sit.
        /// </summary>
        [ExampleValue(7)]
        public int NoSeat { get; set; }

        /// <summary>
        /// The amount of money the player will be playing with.
        /// </summary>
        [ExampleValue(4200)]
        public int MoneyAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="noSeat"></param>
        /// <returns></returns>
        public PlayerSitInResponse Response(int noSeat)
        {
            return new PlayerSitInResponse(this) { NoSeat = noSeat };
        }
    }
}
