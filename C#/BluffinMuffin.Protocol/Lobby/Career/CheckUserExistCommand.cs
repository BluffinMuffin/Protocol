namespace BluffinMuffin.Protocol.Lobby.Career
{
    public class CheckUserExistCommand : AbstractLobbyCommand, ICommandWithResponse<CheckUserExistResponse>
    {
        public string Username { get; set; }

        public CheckUserExistResponse Response(bool exist)
        {
            return new CheckUserExistResponse(this) { Exist = exist };
        }
    }
}
