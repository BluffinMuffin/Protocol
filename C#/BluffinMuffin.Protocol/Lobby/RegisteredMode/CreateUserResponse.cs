using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateUserResponse : AbstractBluffinReponse<CreateUserCommand>
    {
        /// <summary>
        /// true if the user was created successfully
        /// </summary>
        [ExampleValue(true)]
        public bool Success { get; set; }

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
