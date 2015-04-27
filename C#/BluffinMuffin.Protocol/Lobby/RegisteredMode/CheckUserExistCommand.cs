using BluffinMuffin.Protocol.Enums;
using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    /// <summary>
    /// In the User Creation Process, it's useful to check if the username is already taken. You can then validate the username before actually creating the user. (Username is the name used to connect)
    /// </summary>
    public class CheckUserExistCommand : AbstractLobbyCommand, ICommandWithResponse<CheckUserExistResponse>
    {
        /// <summary>
        /// The display name you want to check the existance of
        /// </summary>
        [ExampleValue("ericmas001")]
        public string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public CheckUserExistResponse Response(bool success, BluffinMessageId msgId, string message)
        {
            return new CheckUserExistResponse(this) { Success = success, MessageId = msgId, Message = message };
        }
    }
}
