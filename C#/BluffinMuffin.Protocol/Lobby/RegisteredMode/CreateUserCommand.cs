namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    public class CreateUserCommand : AbstractLobbyCommand, ICommandWithResponse<CreateUserResponse>
    {
        public string Username { get;  set; }
        public string Password { get;  set; }
        public string Email { get;  set; }
        public string DisplayName { get;  set; }

        public CreateUserResponse Response(bool success)
        {
            return new CreateUserResponse(this) { Success = success };
        }
    }
}
