namespace BluffinMuffin.Protocol
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstractLobbyCommand : AbstractBluffinCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public override BluffinCommandEnum CommandType
        {
            get { return BluffinCommandEnum.Lobby; }
        }
    }
}
