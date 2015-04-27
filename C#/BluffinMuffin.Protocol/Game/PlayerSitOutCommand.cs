using BluffinMuffin.Protocol.Enums;

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
        /// <returns></returns>
        public PlayerSitOutResponse Response(bool success, BluffinMessageId msgId, string message)
        {
            return new PlayerSitOutResponse(this) { Success = success, MessageId = msgId, Message = message };
        }
    }
}
