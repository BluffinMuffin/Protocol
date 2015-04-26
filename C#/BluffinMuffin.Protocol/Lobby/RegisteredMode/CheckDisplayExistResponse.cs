using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    /// <summary>
    /// 
    /// </summary>
    public class CheckDisplayExistResponse : AbstractBluffinReponse<CheckDisplayExistCommand>
    {
        /// <summary>
        /// true if the display name exists
        /// </summary>
        [ExampleValue(true)]
        public bool Exist { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public CheckDisplayExistResponse(CheckDisplayExistCommand command)
            : base(command)
        {
        }
    }
}
