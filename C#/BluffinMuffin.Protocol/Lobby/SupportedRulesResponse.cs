using System.Collections.Generic;
using BluffinMuffin.Protocol.DataTypes;

namespace BluffinMuffin.Protocol.Lobby
{
    /// <summary>
    /// 
    /// </summary>
    public class SupportedRulesResponse : AbstractBluffinReponse<SupportedRulesCommand>
    {
        /// <summary>
        /// 
        /// </summary>
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
