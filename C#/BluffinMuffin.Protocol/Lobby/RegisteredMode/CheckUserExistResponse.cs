using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    /// <summary>
    /// 
    /// </summary>
    public class CheckUserExistResponse : AbstractBluffinReponse<CheckUserExistCommand>
    {
        /// <summary>
        /// true if the username exists
        /// </summary>
        [ExampleValue(true)]
        public bool Exist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public CheckUserExistResponse(CheckUserExistCommand command)
            : base(command)
        {
        }
    }
}
