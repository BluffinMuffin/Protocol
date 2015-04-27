using System.Collections.Generic;
using System.Linq;
using BluffinMuffin.Protocol.DataTypes;
using BluffinMuffin.Protocol.Enums;

namespace BluffinMuffin.Protocol.Lobby
{
    /// <summary>
    /// This should be sent one time, at the beginning, to know what the server can do.
    /// All the supported rules are then sent back to the client.
    /// </summary>
    public class SupportedRulesCommand : AbstractLobbyCommand, ICommandWithResponse<SupportedRulesResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SupportedRulesResponse Response(bool success, BluffinMessageId msgId, string message)
        {
            return new SupportedRulesResponse(this) { Success = success, MessageId = msgId, Message = message };
        }
    }
}
