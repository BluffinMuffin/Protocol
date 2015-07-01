namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    /// <summary>
    /// 
    /// </summary>
    public class AuthenticateUserResponse : AbstractBluffinReponse<AuthenticateUserCommand>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public AuthenticateUserResponse(AuthenticateUserCommand command)
            : base(command)
        {
        }
    }
}
