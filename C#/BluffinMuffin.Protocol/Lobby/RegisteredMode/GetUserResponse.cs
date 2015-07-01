using BluffinMuffin.Protocol.DataTypes.Attributes;

namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    /// <summary>
    /// 
    /// </summary>
    public class GetUserResponse : AbstractBluffinReponse<GetUserCommand>
    {
        /// <summary>
        /// The email of the user
        /// </summary>
        [ExampleValue("ericmas001@hotmail.com")]
        public string Email { get; set; }
        /// <summary>
        /// The display name of the user
        /// </summary>
        [ExampleValue("Sponge Bob")]
        public string DisplayName { get; set; }
        /// <summary>
        /// The money currently in bank for this user
        /// </summary>
        [ExampleValue(42000.42)]
        public double Money { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public GetUserResponse(GetUserCommand command)
            : base(command)
        {
        }
    }
}
