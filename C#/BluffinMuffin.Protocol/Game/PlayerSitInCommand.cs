namespace BluffinMuffin.Protocol.Game
{
    public class PlayerSitInCommand : AbstractGameCommand, ICommandWithResponse<PlayerSitInResponse>
    {
        public int NoSeat { get; set; }
        public int MoneyAmount { get; set; }

        public PlayerSitInResponse Response(int noSeat)
        {
            return new PlayerSitInResponse(this) { NoSeat = noSeat };
        }
    }
}
