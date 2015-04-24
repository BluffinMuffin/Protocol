using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes
{
    public class LobbyOptionsCareer : LobbyOptions
    {
        public override LobbyTypeEnum OptionType
        {
            get { return LobbyTypeEnum.Career; }
        }

        /// <summary>
        /// The Money unit. Should always be equal to the moneyUnit of the table.
        /// </summary>
        public int MoneyUnit { get; set; }
        public bool IsMaximumBuyInLimited { get; set; }

        public LobbyOptionsCareer()
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
