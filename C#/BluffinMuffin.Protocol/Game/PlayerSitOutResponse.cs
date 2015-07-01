namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// The response from the server on the SitOutRequest
    /// </summary>
    public class PlayerSitOutResponse : AbstractBluffinReponse<PlayerSitOutCommand>,IGameCommand
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public PlayerSitOutResponse(PlayerSitOutCommand command)
            : base(command)
        {
        }

        /// <summary>
        /// The id of the table where this command needs to go
        /// </summary>
        public int TableId
        {
            get { return Command.TableId; }
        }
    }
}
