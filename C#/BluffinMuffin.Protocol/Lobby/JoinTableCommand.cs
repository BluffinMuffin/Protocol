namespace BluffinMuffin.Protocol.Lobby
{
    public class JoinTableCommand : AbstractLobbyCommand, ICommandWithResponse<JoinTableResponse>
    {
        public int TableId { get; set; }
        public string PlayerName { get; set; }

        public JoinTableResponse Response(bool success)
        {
            return new JoinTableResponse(this) { Success = success };
        }
    }
}
