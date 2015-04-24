using Com.Ericmas001.Net.Protocol;
using Newtonsoft.Json;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes
{
    public class TableParams
    {       
        /// <summary>
        /// The name of the table
        /// </summary>
        [ExampleValue("Bikini Bottom")]
        public string TableName { get; set; }

        /// <summary>
        /// The type of poker
        /// </summary>
        [ExampleValue(GameTypeEnum.Holdem)]
        public GameTypeEnum GameType { get; set; }

        /// <summary>
        /// The variant of the GameType
        /// </summary>
        [ExampleValue("Texas Hold'em")]
        public string Variant { get; set; }

        /// <summary>
        /// The minimum seated players needed to start the game. (Between 2 and 10)
        /// </summary>
        [ExampleValue(2)]
        public int MinPlayersToStart { get; set; }
        /// <summary>
        /// The maximum number of players. (Between 2 and 10, and must be >= MinPlayersToStart)
        /// </summary>
        [ExampleValue(10)]
        public int MaxPlayers { get; set; }
        /// <summary>
        /// The waiting times (At different stage of the game, the server will wait before continuing to making it feel real !)
        /// </summary>
        public ConfigurableWaitingTimes WaitingTimes { get; set; }

        /// <summary>
        /// The unit used by the table. This unit is usually the big blind, the minimum raise, etc.
        /// </summary>
        [ExampleValue(10)]
        public int MoneyUnit { get; set; }

        /// <summary>
        /// The type of table it is (Training ? Career ?) See 'BluffinMuffin.Protocol.DataTypes.LobbyOptions' for more details
        /// </summary>
        [ExampleValue(typeof(LobbyOptionsTraining))]
        [JsonConverter(typeof(OptionJsonConverter<LobbyOptions, LobbyTypeEnum>))]
        [JsonProperty(Order=100)]
        public LobbyOptions Lobby { get; set; }

        /// <summary>
        /// The type of blinds the table uses (none, blinds, antes) See 'BluffinMuffin.Protocol.DataTypes.BlindOptions' for more details
        /// </summary>
        [ExampleValue(typeof(BlindOptionsBlinds))]
        [JsonConverter(typeof(OptionJsonConverter<BlindOptions, BlindTypeEnum>))]
        [JsonProperty(Order = 100)]
        public BlindOptions Blind { get; set; }

        /// <summary>
        /// The type of blinds the table uses (NoLimit, PotLimit, FixedLimit) See 'BluffinMuffin.Protocol.DataTypes.LimitOptions' for more details
        /// </summary>
        [ExampleValue(typeof(LimitOptionsNoLimit))]
        [JsonConverter(typeof(OptionJsonConverter<LimitOptions, LimitTypeEnum>))]
        [JsonProperty(Order = 100)]
        public LimitOptions Limit { get; set; }

        public TableParams()
        {
            TableName = "Anonymous Table";
            GameType = GameTypeEnum.Holdem;
            Variant = "Texas Hold'Em";
            MinPlayersToStart = 2;
            MaxPlayers = 10;
            WaitingTimes = new ConfigurableWaitingTimes();
            MoneyUnit = 10;
            Lobby = new LobbyOptionsTraining();
            Blind = new BlindOptionsNone() { MoneyUnit = MoneyUnit };
            Limit = new LimitOptionsPot();
        }
    }
}
