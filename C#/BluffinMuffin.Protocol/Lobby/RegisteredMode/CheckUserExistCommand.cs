namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
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
