using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Json;
using BluffinMuffin.Protocol.DataTypes.Options;
using Newtonsoft.Json;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes
{
    /// <summary>
    /// 
    /// </summary>
    public class TableParams
    {       
        /// <summary>
        /// The name of the table
        /// </summary>
        [ExampleValue("Bikini Bottom")]
        public string TableName { get; set; }

        /// <summary>
        /// The variant of the GameType
        /// </summary>
        [ExampleValue(GameSubTypeEnum.TexasHoldem)]
        public GameSubTypeEnum Variant { get; set; }

        /// <summary>
        /// The minimum seated players needed to start the game. (Between 2 and 10)
        /// </summary>
        [ExampleValue(2)]
        public int MinPlayersToStart { get; set; }

        /// <summary>
        /// The maximum number of players. (Between 2 and MaxPlayers of the GameInfo, and must be >= MinPlayersToStart)
        /// </summary>
        [ExampleValue(10)]
        public int MaxPlayers { get; set; }

        /// <summary>
        /// The waiting times (At different stage of the game, the server will wait before continuing to making it feel real !)
        /// </summary>
        public ConfigurableWaitingTimes WaitingTimes { get; set; }

        /// <summary>
        /// The size of the table. It represents the small bet and the big blind. Big bet will be double the GameSize, small blind is half the GameSize, and Ante is 1/10 the GameSize
        /// </summary>
        [ExampleValue(10)]
        public int GameSize { get; set; }

        /// <summary>
        /// Some more parameters. Those parameters are specific to a server and are free-format. Generally, this field would be blank.
        /// </summary>
        [ExampleValue("")]
        public string Arguments { get; set; }

        /// <summary>
        /// The type of blinds the table uses (none, blinds, antes)
        /// </summary>
        [ExampleValue(BlindTypeEnum.Blinds)]
        public BlindTypeEnum Blind { get; set; }

        /// <summary>
        /// The type of limit the table uses (NoLimit, PotLimit, FixedLimit)
        /// </summary>
        [ExampleValue(LimitTypeEnum.NoLimit)]
        public LimitTypeEnum Limit { get; set; }

        /// <summary>
        /// The type of table it is (QuickMode ? RegisteredMode ?) See 'BluffinMuffin.Protocol.DataTypes.Options.LobbyOptions' for more details
        /// </summary>
        [ExampleValue(typeof(GameTypeOptionsCommunity))]
        [JsonConverter(typeof(OptionJsonConverter<GameTypeOptions, GameTypeEnum>))]
        [JsonProperty(Order = 100)]
        public GameTypeOptions Options { get; set; }

        /// <summary>
        /// The type of table it is (QuickMode ? RegisteredMode ?) See 'BluffinMuffin.Protocol.DataTypes.Options.GameTypeOptions' for more details
        /// </summary>
        [ExampleValue(typeof(LobbyOptionsQuickMode))]
        [JsonConverter(typeof(OptionJsonConverter<LobbyOptions, LobbyTypeEnum>))]
        [JsonProperty(Order = 100)]
        public LobbyOptions Lobby { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TableParams()
        {
            Arguments = string.Empty;
            TableName = "Anonymous Table";
            Variant = GameSubTypeEnum.TexasHoldem;
            MinPlayersToStart = 2;
            MaxPlayers = 10;
            WaitingTimes = new ConfigurableWaitingTimes();
            GameSize = 10;
            Lobby = new LobbyOptionsQuickMode();
            Blind = BlindTypeEnum.Blinds;
            Limit = LimitTypeEnum.NoLimit;
            Options = new GameTypeOptionsCommunity();
        }

        /// <summary>
        /// MinimumBuyInAmount
        /// </summary>
        [JsonIgnore]
        public int MinimumBuyInAmount
        {
            get
            {
                switch (Lobby.MinimumBuyInParameter)
                {
                    case BuyInParameterEnum.FixedAmount:
                        return Lobby.MinimumBuyInValue;
                    case BuyInParameterEnum.Multiplicator:
                        return Lobby.MinimumBuyInValue*GameSize;
                }
                return 0;
            }
        }

        /// <summary>
        /// MaximumBuyInAmount
        /// </summary>
        [JsonIgnore]
        public int MaximumBuyInAmount
        {
            get
            {
                switch (Lobby.MaximumBuyInParameter)
                {
                    case BuyInParameterEnum.FixedAmount:
                        return Lobby.MaximumBuyInValue;
                    case BuyInParameterEnum.Multiplicator:
                        return Lobby.MaximumBuyInValue * GameSize;
                }
                return int.MaxValue;
            }
        }
    }
}
