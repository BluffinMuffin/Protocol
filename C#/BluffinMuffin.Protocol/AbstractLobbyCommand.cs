using BluffinMuffin.Protocol.Enums;

namespace BluffinMuffin.Protocol
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstractLobbyCommand : AbstractCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public override BluffinCommandEnum CommandType => BluffinCommandEnum.Lobby;
    }
}
