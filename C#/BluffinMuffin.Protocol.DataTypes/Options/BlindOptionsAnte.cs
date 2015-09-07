using BluffinMuffin.Protocol.DataTypes.Enums;
using Newtonsoft.Json;

namespace BluffinMuffin.Protocol.DataTypes.Options
{
    /// <summary>
    /// An ante is a forced bet in which all players put an equal amount of money or chips into the pot before the deal begins. Often this is either a single unit (a one-value or the smallest value in play) or some other small amount; a proportion such as a half or a quarter of the minimum bet is also common. An ante paid by every player ensures that a player who folds every round will lose money (though slowly), thus providing all players with an incentive, however small, to play the hand rather than toss it in when the opening bet reaches them.
    /// [More Info](http://en.wikipedia.org/wiki/Betting_in_poker#Ante)
    /// </summary>
    public class BlindOptionsAnte : BlindOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public override BlindTypeEnum OptionType => BlindTypeEnum.Antes;

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public int AnteAmount => MoneyUnit;
    }
}
