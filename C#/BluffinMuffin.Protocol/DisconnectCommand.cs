using BluffinMuffin.Protocol.Enums;

namespace BluffinMuffin.Protocol
{
    /// <summary>
    /// This command is sent to inform the other end of the Tcp Connection that the communication should end
    /// </summary>
    public class DisconnectCommand : AbstractBluffinCommand
    {
        /// <summary>
        /// 
        /// </summary>
        public override BluffinCommandEnum CommandType
        {
            get { return BluffinCommandEnum.General; }
        }
    }
}
