using System.ComponentModel;

namespace BluffinMuffin.Protocol.DataTypes.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameTypeEnum
    {

        /// <summary>
        /// Games in which each player's incomplete hidden hand is combined with shared face-up cards. The most common of these are Texas hold 'em and Omaha hold 'em.
        /// </summary>
        [Description("Community Cards Poker (Hold'Em)")]
        CommunityCardsPoker,

        /// <summary>
        /// Games in which each player receives a combination of face-up cards and face-down cards in multiple betting rounds. The most common of these are Seven-card stud and Five-card stud.
        /// </summary>
        [Description("Stud Poker")]
        StudPoker,

        /// <summary>
        /// Games in which players are dealt a complete hand, hidden, and then improve it by replacing cards. The most common of these is Five-card draw.
        /// </summary>
        [Description("Draw Poker")]
        DrawPoker,

    }
}
