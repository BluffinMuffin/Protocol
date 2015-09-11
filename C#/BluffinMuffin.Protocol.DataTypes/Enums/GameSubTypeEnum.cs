using System.ComponentModel;
using BluffinMuffin.Protocol.DataTypes.Attributes;

namespace BluffinMuffin.Protocol.DataTypes.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameSubTypeEnum
    {
        /// <summary>
        /// Community Cards Poker (Hold'Em) : Texas Hold'em
        /// </summary>
        [GameType(GameTypeEnum.CommunityCardsPoker)]
        [Description("Texas Hold'em")]
        TexasHoldem,

        /// <summary>
        /// Community Cards Poker (Hold'Em) : Omaha Hold'em
        /// </summary>
        [GameType(GameTypeEnum.CommunityCardsPoker)]
        [Description("Omaha Hold'em")]
        OmahaHoldem,

        /// <summary>
        /// Community Cards Poker (Hold'Em) : Pineapple
        /// </summary>
        [GameType(GameTypeEnum.CommunityCardsPoker)]
        [Description("Pineapple")]
        Pineapple,

        /// <summary>
        /// Community Cards Poker (Hold'Em) : Crazy Pineapple
        /// </summary>
        [GameType(GameTypeEnum.CommunityCardsPoker)]
        [Description("Crazy Pineapple")]
        CrazyPineapple,

        /// <summary>
        /// Community Cards Poker (Hold'Em) : Lazy Pineapple
        /// </summary>
        [GameType(GameTypeEnum.CommunityCardsPoker)]
        [Description("Lazy Pineapple")]
        LazyPineapple,

        /// <summary>
        /// Community Cards Poker (Hold'Em) : Three Cards Hold'em
        /// </summary>
        [GameType(GameTypeEnum.CommunityCardsPoker)]
        [Description("Three Cards Hold'em")]
        ThreeCardsHoldem,

        /// <summary>
        /// Community Cards Poker (Hold'Em) : Irish Poker
        /// </summary>
        [GameType(GameTypeEnum.CommunityCardsPoker)]
        [Description("Irish Poker")]
        IrishPoker,

        /// <summary>
        /// Stud Poker : Five Cards Stud
        /// </summary>
        [GameType(GameTypeEnum.StudPoker)]
        [Description("Five Cards Stud")]
        FiveCardsStud,

        /// <summary>
        /// Stud Poker : Seven Cards Stud
        /// </summary>
        [GameType(GameTypeEnum.StudPoker)]
        [Description("Seven Cards Stud")]
        SevenCardsStud,

        /// <summary>
        /// Draw Poker : Five Cards Draw
        /// </summary>
        [GameType(GameTypeEnum.DrawPoker)]
        [Description("Five Cards Draw")]
        FiveCardsDraw,

    }
}
