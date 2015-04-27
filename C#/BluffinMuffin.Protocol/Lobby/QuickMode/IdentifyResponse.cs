using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Lobby.QuickMode
{
    /// <summary>
    /// 
    /// </summary>
    public class IdentifyResponse : AbstractBluffinReponse<IdentifyCommand>
    {
        /// <summary>
        /// Indicates if the identification was successful
        /// </summary>
        [ExampleValue(true)]
        public bool Ok { get; set; }
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
