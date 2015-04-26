using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    /// <summary>
    /// This command will Get the information about a player. This information should be only for the player itself.
    /// </summary>
    public class GetUserCommand : AbstractLobbyCommand, ICommandWithResponse<GetUserResponse>
    {
        /// <summary>
        /// The username you want to know more about
        /// </summary>
        [ExampleValue("ericmas001")]
        public string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mail"></param>
        /// <param name="display"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public GetUserResponse Response(string mail, string display, double money)
        {
            return new GetUserResponse(this)
            {
                Email = mail,
                DisplayName = display,
                Money = money,
            };
        }
    }
}
