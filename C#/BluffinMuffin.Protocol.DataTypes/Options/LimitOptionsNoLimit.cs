using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes.Options
{
    /// <summary>
    /// A game played with a no-limit betting structure allows each player to raise the bet by any amount up to and including his entire remaining stake at any time. There is generally a minimum opening bet, and raises usually must be at least the amount of the previous raise.
    /// [More Info](http://en.wikipedia.org/wiki/Betting_in_poker#No_limit)
    /// </summary>
    public class LimitOptionsNoLimit : LimitOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public override LimitTypeEnum OptionType { get { return LimitTypeEnum.NoLimit; } }
    }
}
