using BluffinMuffin.Protocol.Enums;
using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    /// <summary>
    /// This command will Get the information about a player. This information should be only for the player itself.
    /// </summary>
    public class GetUserCommand : AbstractLobbyCommand, ICommandWithResponse<GetUserResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public GetUserResponse Response(bool success, BluffinMessageId msgId, string message)
        {
            return new GetUserResponse(this) { Success = success, MessageId = msgId, Message = message };
        }
    }
}
