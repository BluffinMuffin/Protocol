namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    public class AuthenticateUserCommand : AbstractLobbyCommand, ICommandWithResponse<AuthenticateUserResponse>
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public AuthenticateUserResponse Response(bool success)
        {
            return new AuthenticateUserResponse(this) { Success = success };
        }
    }
}
