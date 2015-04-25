namespace BluffinMuffin.Protocol.Lobby
{
    /// <summary>
    /// 
    /// </summary>
    public class JoinTableResponse : AbstractBluffinReponse<JoinTableCommand>
    {
        /// <summary>
        /// true if the player has joined the table on the server
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public JoinTableResponse(JoinTableCommand command)
            : base(command)
        {
        }
    }
}
