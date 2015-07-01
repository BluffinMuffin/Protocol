using BluffinMuffin.Protocol.DataTypes;
using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.Lobby
{
    /// <summary>
    /// 
    /// </summary>
    public class CheckCompatibilityResponse : AbstractBluffinReponse<CheckCompatibilityCommand>
    {
        /// <summary>
        /// The version of the Implemented Bluffin Protocol by the server
        /// </summary>
        [ExampleValue("1.0")]
        public string ImplementedProtocolVersion { get; set; }

        /// <summary>
        /// All the rules supported by the server
        /// </summary>
        [ExampleValues(2, LobbyTypeEnum.QuickMode, LobbyTypeEnum.RegisteredMode)]
        public LobbyTypeEnum[] SupportedLobbyTypes { get; set; }

        /// <summary>
        /// All the rules supported by the server
        /// </summary>
        [ExampleValues(1)]
        public RuleInfo[] Rules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public CheckCompatibilityResponse(CheckCompatibilityCommand command)
            : base(command)
        {
        }
    }
}
