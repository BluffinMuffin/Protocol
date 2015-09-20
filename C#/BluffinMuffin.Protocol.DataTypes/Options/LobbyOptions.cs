using BluffinMuffin.Protocol.DataTypes.Enums;
using Newtonsoft.Json;

namespace BluffinMuffin.Protocol.DataTypes.Options
{
    /// <summary>
    /// The type of table it is (QuickMode ? RegisteredMode ?)
    /// </summary>
    public abstract class LobbyOptions : IOption<LobbyTypeEnum>
    {
        /// <summary>
        /// What type of lobby it is
        /// </summary>
        public abstract LobbyTypeEnum OptionType { get; }

        /// <summary>
        /// MinimumBuyInParameter
        /// </summary>
        [JsonIgnore]
        public abstract BuyInParameterEnum MinimumBuyInParameter { get; }

        /// <summary>
        /// MinimumBuyInValue
        /// </summary>
        [JsonIgnore]
        public abstract int MinimumBuyInValue { get; }

        /// <summary>
        /// MaximumBuyInParameter
        /// </summary>
        [JsonIgnore]
        public abstract BuyInParameterEnum MaximumBuyInParameter { get; }

        /// <summary>
        /// MaximumBuyInValue
        /// </summary>
        [JsonIgnore]
        public abstract int MaximumBuyInValue { get; }
    }
}
