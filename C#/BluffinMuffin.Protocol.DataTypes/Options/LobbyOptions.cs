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
        /// 
        /// </summary>
        [JsonIgnore]
        public abstract int MinimumAmountForBuyIn { get; }
        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public abstract int MaximumAmountForBuyIn { get; }
    }
}
