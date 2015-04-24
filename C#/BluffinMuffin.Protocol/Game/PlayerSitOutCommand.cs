namespace BluffinMuffin.Protocol.Game
{
    public class PlayerSitOutCommand : AbstractGameCommand, ICommandWithResponse<PlayerSitOutResponse>
    {
        public PlayerSitOutResponse Response(bool success)
        {
            return new PlayerSitOutResponse(this) { Success = success };
        }
    }
}
