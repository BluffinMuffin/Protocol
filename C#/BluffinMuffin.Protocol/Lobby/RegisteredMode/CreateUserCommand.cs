using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.Enums;

namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    /// <summary>
    /// This commands will create a new user in the database.
    /// </summary>
    public class CreateUserCommand : AbstractLobbyCommand, ICommandWithResponse<CreateUserResponse>
    {
        /// <summary>
        /// The username you want to have
        /// </summary>
        [ExampleValue("ericmas001")]
        public string Username { get; set; }
        /// <summary>
        /// The password you want to use
        /// </summary>
        [ExampleValue("0nc3Up0nAT1m3")]
        public string Password { get; set; }
        /// <summary>
        /// An email address to reach this user
        /// </summary>
        [ExampleValue("ericmas001@hotmail.com")]
        public string Email { get; set; }
        /// <summary>
        /// The display name you want for this user
        /// </summary>
        [ExampleValue("Sponge Bob")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public CreateUserResponse Response(bool success, BluffinMessageId msgId, string message)
        {
            return new CreateUserResponse(this) { Success = success, MessageId = msgId, Message = message };
        }
    }
}
