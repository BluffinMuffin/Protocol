using BluffinMuffin.Protocol.DataTypes.Attributes;

namespace BluffinMuffin.Protocol.Lobby
{
    /// <summary>
    /// To leave a table, you have to send a **Leave Table ** command with the id of the table you want to leave.
    /// </summary>
    public class LeaveTableCommand : AbstractLobbyCommand
    {
        /// <summary>
        /// The id of the table to leave
        /// </summary>
        [ExampleValue(42)]
        public int TableId { get; set; }
    }
}
