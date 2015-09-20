using BluffinMuffin.Protocol.DataTypes;
using BluffinMuffin.Protocol.Enums;

namespace BluffinMuffin.Protocol.Lobby
{
    /// <summary>
    /// To create a new table, you have to send a **Create Table** command with all the parameters of the poker table.
    /// If successful, the id of the table will be received. If not, server will send "-1".
    /// More information on ...
    ///  * [LobbyOptions]({BluffinMuffin.Protocol.DataTypes.Options.LobbyOptions})
    ///  * [GameTypeOptions]({BluffinMuffin.Protocol.DataTypes.Options.GameTypeOptions})
    /// </summary>
    public class CreateTableCommand : AbstractLobbyCommand, ICommandWithResponse<CreateTableResponse>
    {
        /// <summary>
        /// Parameters of the poker table
        /// </summary>
        public TableParams Params { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public CreateTableResponse Response(bool success, BluffinMessageId msgId, string message)
        {
            return new CreateTableResponse(this) { Success = success, MessageId = msgId, Message = message };
        }
    }
}
