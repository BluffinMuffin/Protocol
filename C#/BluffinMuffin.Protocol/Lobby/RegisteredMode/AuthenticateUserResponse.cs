using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    /// <summary>
    /// 
    /// </summary>
    public class AuthenticateUserResponse : AbstractBluffinReponse<AuthenticateUserCommand>
    {
        /// <summary>
        /// true if the username existed and the password was correct
        /// </summary>
        [ExampleValue(true)]
        public bool Success { get; set; }

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
