namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    public class CreateUserResponse : AbstractBluffinReponse<CreateUserCommand>
    {
        public bool Success { get; set; }

        public CreateUserResponse(CreateUserCommand command)
            : base(command)
        {
        }
    }
}
