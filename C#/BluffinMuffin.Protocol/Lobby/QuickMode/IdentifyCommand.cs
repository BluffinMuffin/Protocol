using BluffinMuffin.Protocol.Enums;
using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Lobby.QuickMode
{
    /// <summary>
    /// In Quick mode, you must **identify** yourself. This action puts a unique name to your Tcp Connection for the server. This name will be used as your playername on every table that you will play.
    /// </summary>
    public class IdentifyCommand : AbstractLobbyCommand, ICommandWithResponse<IdentifyResponse>
    {
        /// <summary>
        /// The name you want to have on the server !
        /// </summary>
        [ExampleValue("SpongeBob")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IdentifyResponse Response(bool success, BluffinMessageId msgId, string message)
        {
            return new IdentifyResponse(this) { Success = success, MessageId = msgId, Message = message };
        }
    }
}
