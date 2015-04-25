using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes
{
    /// <summary>
    /// The Quick mode is a mode where the money is given to the player when he enters the table. For example, If the amount is set to 1500 on Table1, every player will receive 1500$ to play with when they will enter the Table.
    /// </summary>
    public class LobbyOptionsQuickMode : LobbyOptions
    {
        public override LobbyTypeEnum OptionType
        {
            get { return LobbyTypeEnum.QuickMode; }
        }

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

        public override int MaximumAmountForBuyIn
        {
            get { return StartingAmount; }
        }

        public override int MinimumAmountForBuyIn
        {
            get { return StartingAmount; }
        }
    }
}
