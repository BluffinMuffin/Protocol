using System.Collections.Generic;
using System.Linq;
using BluffinMuffin.Protocol.DataTypes;

namespace BluffinMuffin.Protocol.Lobby
{
    /// <summary>
    /// This should be sent one time, at the beginning, to know what the server can do.
    /// All the supported rules are then sent back to the client.
    /// </summary>
    public class SupportedRulesCommand : AbstractLobbyCommand, ICommandWithResponse<SupportedRulesResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rules"></param>
        /// <returns></returns>
        public SupportedRulesResponse Response(IEnumerable<RuleInfo> rules)
        {
            return new SupportedRulesResponse(this) { Rules = rules.ToList() };
        }
    }
}
