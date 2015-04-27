namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// The client is telling the server that he wants to sit out
    /// </summary>
    public class PlayerSitOutCommand : AbstractGameCommand, ICommandWithResponse<PlayerSitOutResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="success"></param>
        /// <returns></returns>
        public PlayerSitOutResponse Response(bool success)
        {
            return new PlayerSitOutResponse(this) { Success = success };
        }
    }
}
