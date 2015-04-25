namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    public class AuthenticateUserResponse : AbstractBluffinReponse<AuthenticateUserCommand>
    {
        public bool Success { get; set; }

        public AuthenticateUserResponse(AuthenticateUserCommand command)
            : base(command)
        {
        }
    }
}
