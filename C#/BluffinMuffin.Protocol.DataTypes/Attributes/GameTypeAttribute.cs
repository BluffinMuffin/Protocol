using System;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    public class GameTypeAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public GameTypeEnum GameType { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gameType"></param>
        public GameTypeAttribute(GameTypeEnum gameType)
        {
            GameType = gameType;
        }
    }
}
