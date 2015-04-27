using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Lobby
{
    /// <summary>
    /// To join a table, you have to send a **Join Table ** command with the id of the table you want to join.
    /// The success of the operation will be sent back
    /// </summary>
    public class JoinTableCommand : AbstractLobbyCommand, ICommandWithResponse<JoinTableResponse>
    {
        /// <summary>
        /// The id of the table to join
        /// </summary>
        [ExampleValue(42)]
        public int TableId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="success"></param>
        /// <returns></returns>
        public JoinTableResponse Response(bool success)
        {
            return new JoinTableResponse(this) { Success = success };
        }
    }
}
