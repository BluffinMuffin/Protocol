namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateUserResponse : AbstractBluffinReponse<CreateUserCommand>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public CreateUserResponse(CreateUserCommand command)
            : base(command)
        {
        }
    }
}
