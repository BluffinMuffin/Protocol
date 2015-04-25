using BluffinMuffin.Protocol.DataTypes.Enums;
using System.Collections.Generic;

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
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public GameTypeEnum GameType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MinPlayers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MaxPlayers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<LimitTypeEnum> AvailableLimits { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public LimitTypeEnum DefaultLimit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<BlindTypeEnum> AvailableBlinds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public BlindTypeEnum DefaultBlind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool CanConfigWaitingTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<LobbyTypeEnum> AvailableLobbys { get; set; }
    }
}
