using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes
{
    /// <summary>
    /// In a pot-limit game no player can raise more than the size of the total pot, which includes Chips collected from previous betting rounds (Starting pot), Previous action in the current betting round (Trail) and A call from the player making the raise
    /// [More Info](http://en.wikipedia.org/wiki/Betting_in_poker#Pot_limit)
    /// </summary>
    public class LimitOptionsPot : LimitOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public override LimitTypeEnum OptionType { get { return LimitTypeEnum.PotLimit; } }
    }
}
