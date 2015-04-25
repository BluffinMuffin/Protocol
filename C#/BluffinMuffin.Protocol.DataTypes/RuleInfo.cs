using BluffinMuffin.Protocol.DataTypes.Enums;
using System.Collections.Generic;
using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.DataTypes
{
    /// <summary>
    /// 
    /// </summary>
    public class RuleInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [ExampleValue("TODO")]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ExampleValue("TODO")]
        public GameTypeEnum GameType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ExampleValue("TODO")]
        public int MinPlayers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ExampleValue("TODO")]
        public int MaxPlayers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ExampleValue("TODO")]
        public List<LimitTypeEnum> AvailableLimits { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ExampleValue("TODO")]
        public LimitTypeEnum DefaultLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ExampleValue("TODO")]
        public List<BlindTypeEnum> AvailableBlinds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ExampleValue("TODO")]
        public BlindTypeEnum DefaultBlind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ExampleValue("TODO")]
        public bool CanConfigWaitingTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ExampleValue("TODO")]
        public List<LobbyTypeEnum> AvailableLobbys { get; set; }
    }
}
