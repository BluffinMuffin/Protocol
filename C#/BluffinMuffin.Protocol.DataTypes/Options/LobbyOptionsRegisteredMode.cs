using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes.Options
{
    /// <summary>
    /// The Registered mode is a mode where a player connects with an account. He then have some money, that he uses throughout different games. When entering a game, he will take some of that money to play, and when he leaves what was left of that money will be given back to him.
    /// </summary>
    public class LobbyOptionsRegisteredMode : LobbyOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public override LobbyTypeEnum OptionType => LobbyTypeEnum.RegisteredMode;

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
        /// <summary>
        /// 
        /// </summary>
        public override int MaximumAmountForBuyIn => IsMaximumBuyInLimited ? 100 * MoneyUnit : int.MaxValue;

        /// <summary>
        /// 
        /// </summary>
        public override int MinimumAmountForBuyIn => 20 * MoneyUnit;
    }
}
