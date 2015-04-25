using System.Collections.Generic;
using BluffinMuffin.Protocol.DataTypes;
using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Lobby
{
    /// <summary>
    /// 
    /// </summary>
    public class SupportedRulesResponse : AbstractBluffinReponse<SupportedRulesCommand>
    {
        /// <summary>
        /// All the rules supported by the server
        /// </summary>
        [ExampleValues(1)]
        public List<RuleInfo> Rules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public SupportedRulesResponse(SupportedRulesCommand command)
            : base(command)
        {
        }
    }
}
