using BluffinMuffin.Protocol.DataTypes.Enums;
using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.DataTypes
{
    /// <summary>
    /// The Registered mode is a mode where a player connects with an account. He then have some money, that he uses throughout different games. When entering a game, he will take some of that money to play, and when he leaves what was left of that money will be given back to him.
    /// </summary>
    public class LobbyOptionsRegisteredMode : LobbyOptions
    {
        public override LobbyTypeEnum OptionType
        {
            get { return LobbyTypeEnum.RegisteredMode; }
        }

        /// <summary>
        /// The Money unit. Should always be equal to the moneyUnit of the table.
        /// </summary>
        [ExampleValue(10)]
        public int MoneyUnit { get; set; }

        /// <summary>
        /// If Limited, the maximum buy-in will be 100*MoneyUnit. If not, a player can sit with all his money if he wants.
        /// </summary>
        [ExampleValue(true)]
        public bool IsMaximumBuyInLimited { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public LobbyOptionsRegisteredMode()
        {
            MoneyUnit = 10;
            IsMaximumBuyInLimited = false;
        }
        public override int MaximumAmountForBuyIn
        {
            get { return IsMaximumBuyInLimited ? 100 * MoneyUnit : int.MaxValue; }
        }
        public override int MinimumAmountForBuyIn
        {
            get { return 20 * MoneyUnit; }
        }
    }
}
