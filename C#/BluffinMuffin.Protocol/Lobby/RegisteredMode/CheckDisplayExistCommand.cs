using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.Enums;

namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    /// <summary>
    /// In the User Creation Process, it's useful to check if the display name is already taken. You can then validate the display name before actually creating the user. (Display name is the name viewed by other players on the table)
    /// </summary>
    public class CheckDisplayExistCommand : AbstractLobbyCommand, ICommandWithResponse<CheckDisplayExistResponse>
    {
        /// <summary>
        /// The display name you want to check the existance of
        /// </summary>
        [ExampleValue("Sponge Bob")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public CheckDisplayExistResponse Response(bool success, BluffinMessageId msgId, string message)
        {
            return new CheckDisplayExistResponse(this) { Success = success, MessageId = msgId, Message = message };
        }
    }
}
