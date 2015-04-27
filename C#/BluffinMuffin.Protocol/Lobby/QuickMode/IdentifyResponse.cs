using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Lobby.QuickMode
{
    /// <summary>
    /// 
    /// </summary>
    public class IdentifyResponse : AbstractBluffinReponse<IdentifyCommand>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public IdentifyResponse(IdentifyCommand command)
            : base(command)
        {
        }
    }
}
