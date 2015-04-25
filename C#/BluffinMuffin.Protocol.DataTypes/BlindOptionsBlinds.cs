using BluffinMuffin.Protocol.DataTypes.Enums;
using Newtonsoft.Json;

namespace BluffinMuffin.Protocol.DataTypes
{
    /// <summary>
    /// A blind bet or just blind is a forced bet placed into the pot by one or more players before the deal begins, in a way that simulates bets made during play. The most common use of blinds as a betting structure calls for two blinds: the player after the dealer blinds about half of what would be a normal bet, and the next player blinds what would be a whole bet.
    /// [More Info](http://en.wikipedia.org/wiki/Betting_in_poker#Blinds)
    /// </summary>
    public class BlindOptionsBlinds : BlindOptions
    {
        public override BlindTypeEnum OptionType { get { return BlindTypeEnum.Blinds; } }

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public int BigBlindAmount { get { return MoneyUnit; } }
        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public int SmallBlindAmount { get { return MoneyUnit / 2; } }
    }
}
