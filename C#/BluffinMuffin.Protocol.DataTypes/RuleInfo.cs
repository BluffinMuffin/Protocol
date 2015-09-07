using BluffinMuffin.Protocol.DataTypes.Attributes;
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
        /// Type of Game
        /// </summary>
        [ExampleValue(GameTypeEnum.CommunityCardsPoker)]
        public GameTypeEnum GameType { get; set; }
        /// <summary>
        /// Name of the Variant
        /// </summary>
        [ExampleValue("Texas Hold'em")]
        public string Name { get; set; }
        /// <summary>
        /// Minimum amount of sitting player required to start a game
        /// </summary>
        [ExampleValue(2)]
        public int MinPlayers { get; set; }
        /// <summary>
        /// Maximum amount of players that can sit at the table (Must be >= MinPlayers)
        /// </summary>
        [ExampleValue(10)]
        public int MaxPlayers { get; set; }
        /// <summary>
        /// Avaliable limits
        /// </summary>
        [ExampleValues(1,LimitTypeEnum.NoLimit)]
        public List<LimitTypeEnum> AvailableLimits { get; set; }
        /// <summary>
        /// Default Limit
        /// </summary>
        [ExampleValue(LimitTypeEnum.NoLimit)]
        public LimitTypeEnum DefaultLimit { get; set; }
        /// <summary>
        /// Available Blind Options
        /// </summary>
        [ExampleValues(3, BlindTypeEnum.Blinds, BlindTypeEnum.Antes, BlindTypeEnum.None)]
        public List<BlindTypeEnum> AvailableBlinds { get; set; }
        /// <summary>
        /// Default Blind Option
        /// </summary>
        [ExampleValue(BlindTypeEnum.Blinds)]
        public BlindTypeEnum DefaultBlind { get; set; }
        /// <summary>
        /// Are waiting times configurable ?? (At different stage of the game, the server will wait before continuing to making it feel real !)
        /// </summary>
        [ExampleValue(true)]
        public bool CanConfigWaitingTime { get; set; }
        /// <summary>
        /// What kind of lobby are offered ?
        /// </summary>
        [ExampleValues(2, LobbyTypeEnum.QuickMode, LobbyTypeEnum.RegisteredMode)]
        public List<LobbyTypeEnum> AvailableLobbys { get; set; }
    }
}
