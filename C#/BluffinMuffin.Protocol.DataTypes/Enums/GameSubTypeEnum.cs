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
        TexasHoldem,

        /// <summary>
        /// Community Cards Poker (Hold'Em) : Omaha Hold'em
        /// </summary>
        [GameType(GameTypeEnum.CommunityCardsPoker)]
        OmahaHoldem,

        /// <summary>
        /// Community Cards Poker (Hold'Em) : Pineapple
        /// </summary>
        [GameType(GameTypeEnum.CommunityCardsPoker)]
        Pineapple,

        /// <summary>
        /// Community Cards Poker (Hold'Em) : Crazy Pineapple
        /// </summary>
        [GameType(GameTypeEnum.CommunityCardsPoker)]
        CrazyPineapple,

        /// <summary>
        /// Community Cards Poker (Hold'Em) : Lazy Pineapple
        /// </summary>
        [GameType(GameTypeEnum.CommunityCardsPoker)]
        LazyPineapple,

        /// <summary>
        /// Community Cards Poker (Hold'Em) : Three Cards Hold'em
        /// </summary>
        [GameType(GameTypeEnum.CommunityCardsPoker)]
        ThreeCardsHoldem,

        /// <summary>
        /// Community Cards Poker (Hold'Em) : Irish Poker
        /// </summary>
        [GameType(GameTypeEnum.CommunityCardsPoker)]
        IrishPoker,

        /// <summary>
        /// Community Cards Poker (Hold'Em) : Spanish Poker
        /// </summary>
        [GameType(GameTypeEnum.CommunityCardsPoker)]
        SpanishPoker,

        /// <summary>
        /// Community Cards Poker (Hold'Em) : Manila Poker
        /// </summary>
        [GameType(GameTypeEnum.CommunityCardsPoker)]
        ManilaPoker,

        /// <summary>
        /// Stud Poker : Five Cards Stud
        /// </summary>
        [GameType(GameTypeEnum.StudPoker)]
        FiveCardsStud,

        /// <summary>
        /// Stud Poker : Seven Cards Stud
        /// </summary>
        [GameType(GameTypeEnum.StudPoker)]
        SevenCardsStud,

        /// <summary>
        /// Draw Poker : Five Cards Draw
        /// </summary>
        [GameType(GameTypeEnum.DrawPoker)]
        FiveCardsDraw,

    }
}
