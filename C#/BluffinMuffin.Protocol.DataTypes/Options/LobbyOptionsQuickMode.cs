using BluffinMuffin.Protocol.DataTypes.Enums;
using Newtonsoft.Json;

namespace BluffinMuffin.Protocol.DataTypes.Options
{
    /// <summary>
    /// The Quick mode is a mode where the money is given to the player when he enters the table. For example, If the amount is set to 1500 on Table1, every player will receive 1500$ to play with when they will enter the Table.
    /// </summary>
    public class LobbyOptionsQuickMode : LobbyOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public override LobbyTypeEnum OptionType => LobbyTypeEnum.QuickMode;

        /// <summary>
        /// MinimumBuyInParameter
        /// </summary>
        [JsonIgnore]
        public override BuyInParameterEnum MinimumBuyInParameter => BuyInParameterEnum.FixedAmount;

        /// <summary>
        /// MinimumBuyInValue
        /// </summary>
        [JsonIgnore]
        public override int MinimumBuyInValue => StartingAmount;
        /// <summary>
        /// MaximumBuyInParameter
        /// </summary>
        [JsonIgnore]
        public override BuyInParameterEnum MaximumBuyInParameter => BuyInParameterEnum.FixedAmount;

        /// <summary>
        /// MaximumBuyInValue
        /// </summary>
        [JsonIgnore]
        public override int MaximumBuyInValue => StartingAmount;

        /// <summary>
        /// The amount of money that will be given to every player that sits in.
        /// </summary>
        public int StartingAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public LobbyOptionsQuickMode()
        {
            StartingAmount = 1500;
        }
    }
}
