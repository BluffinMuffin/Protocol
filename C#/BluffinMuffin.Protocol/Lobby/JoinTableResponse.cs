namespace BluffinMuffin.Protocol.Lobby
{
    /// <summary>
    /// 
    /// </summary>
    public class JoinTableResponse : AbstractBluffinReponse<JoinTableCommand>
    {
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
