using System.Collections.Generic;
using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes
{
    /// <summary>
    /// Information of a Poker Game Type
    /// </summary>
    public class GameInfo
    {
        /// <summary>
        /// Type of Game
        /// </summary>
        [ExampleValue(GameTypeEnum.CommunityCardsPoker)]
        public GameTypeEnum GameType { get; set; }

        /// <summary>
        /// Available variants of this type of game
        /// </summary>
        [ExampleValues(3, GameSubTypeEnum.TexasHoldem, GameSubTypeEnum.OmahaHoldem, GameSubTypeEnum.CrazyPineapple)]
        public GameSubTypeEnum[] AvailableVariants { get; set; }

        /// <summary>
        /// Available betting limits for this type of game
        /// </summary>
        [ExampleValues(3, LimitTypeEnum.NoLimit, LimitTypeEnum.FixedLimit, LimitTypeEnum.PotLimit)]
        public LimitTypeEnum[] AvailableLimits { get; set; }

        /// <summary>
        /// Available blind types for this type of game
        /// </summary>
        [ExampleValues(1, BlindTypeEnum.Blinds)]
        public BlindTypeEnum[] AvailableBlinds { get; set; }

        /// <summary>
        /// Minimum number of player on the table to be able to play the game
        /// </summary>
        [ExampleValue(2)]
        public int MinPlayers { get; set; }

        /// <summary>
        /// Maximum number of player on the table
        /// </summary>
        [ExampleValue(10)]
        public int MaxPlayers { get; set; }
    }
}
