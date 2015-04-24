using BluffinMuffin.Protocol.DataTypes.Enums;
using Com.Ericmas001.Net.Protocol.Options;
using Newtonsoft.Json;

namespace BluffinMuffin.Protocol.DataTypes
{
    public abstract class LobbyOptions : IOption<LobbyTypeEnum>
    {
        /// <summary>
        /// What type of lobby it is
        /// </summary>
        public abstract LobbyTypeEnum OptionType { get; }

        [JsonIgnore]
        public abstract int MinimumAmountForBuyIn { get; }
        [JsonIgnore]
        public abstract int MaximumAmountForBuyIn { get; }
    }
}
