using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.Enums;

namespace BluffinMuffin.Protocol.Lobby
{
    /// <summary>
    /// This should be sent one time, at the beginning, to know what the server can do.
    /// The supported version, all the supported lobby types and all the supported rules are then sent back to the client.
    /// </summary>
    public class CheckCompatibilityCommand : AbstractLobbyCommand, ICommandWithResponse<CheckCompatibilityResponse>
    {
        /// <summary>
        /// The version of the Implemented Bluffin Protocol by the client, Represented as "Major.Minor.Revision"
        /// </summary>
        [ExampleValue("2.0.0")]
        public string ImplementedProtocolVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public CheckCompatibilityResponse Response(bool success, BluffinMessageId msgId, string message)
        {
            return new CheckCompatibilityResponse(this) { Success = success, MessageId = msgId, Message = message };
        }
    }
}
