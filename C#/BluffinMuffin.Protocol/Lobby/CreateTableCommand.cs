using BluffinMuffin.Protocol.DataTypes;

namespace BluffinMuffin.Protocol.Lobby
{
    /// <summary>
    /// To create a new table, you have to send a **Create Table** command with all the parameters of the poker table.
    /// If successful, the id of the table will be received. If not, server will send "-1".
    /// More information on ...
    ///  * [LobbyOptions]({BluffinMuffin.Protocol.DataTypes.LobbyOptions})
    ///  * [BlindOptions]({BluffinMuffin.Protocol.DataTypes.BlindOptions})
    ///  * [LimitOptions]({BluffinMuffin.Protocol.DataTypes.LimitOptions})
    /// </summary>
    public class CreateTableCommand : AbstractLobbyCommand, ICommandWithResponse<CreateTableResponse>
    {
        /// <summary>
        /// Parameters of the poker table
        /// </summary>
        public TableParams Params { get; set; }

        public CreateTableResponse Response(int id)
        {
            return new CreateTableResponse(this) { IdTable = id };
        }
    }
}
