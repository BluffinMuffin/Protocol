using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    /// <summary>
    /// This command will Get the information about a player. This information should be only for the player itself.
    /// </summary>
    public class GetUserCommand : AbstractLobbyCommand, ICommandWithResponse<GetUserResponse>
    {
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
