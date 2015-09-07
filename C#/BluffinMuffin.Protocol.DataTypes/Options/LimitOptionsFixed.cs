using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes.Options
{
    /// <summary>
    /// In a game played with a fixed-limit betting structure, a player chooses only whether to bet or not - the amount is fixed by rule. To enable the possibility of bluffing and protection, the fixed amount generally doubles at some point in the game. This double wager amount is referred to as a big bet.
    /// [More Info](http://en.wikipedia.org/wiki/Betting_in_poker#Fixed_limit)
    /// </summary>
    public class LimitOptionsFixed : LimitOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public override LimitTypeEnum OptionType => LimitTypeEnum.FixedLimit;
    }
}
