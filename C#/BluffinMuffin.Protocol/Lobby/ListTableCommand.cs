using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Enums;
using BluffinMuffin.Protocol.Enums;

namespace BluffinMuffin.Protocol.Lobby
{
    /// <summary>
    /// To list tables, you have to send a **List Table** command with the types of lobbys you are interested in.
    /// The list of active tables will be sent back
    /// </summary>
    public class ListTableCommand : AbstractLobbyCommand, ICommandWithResponse<ListTableResponse>
    {
        /// <summary>
        /// All the different types of lobby we want to see tables of.
        /// </summary>
        [ExampleValues(2, LobbyTypeEnum.QuickMode, LobbyTypeEnum.RegisteredMode)]
        public LobbyTypeEnum[] LobbyTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ListTableResponse Response(bool success, BluffinMessageId msgId, string message)
        {
            return new ListTableResponse(this) { Success = success, MessageId = msgId, Message = message };
        }
    }
}
