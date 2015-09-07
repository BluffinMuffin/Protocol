using BluffinMuffin.Protocol.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BluffinMuffin.Protocol.Tests.Comparing
{
    public static class ComparePlayerInfo
    {
        public static void Compare(PlayerInfo p, PlayerInfo dp)
        {
            Assert.AreEqual(p.VisibleCards.Length, dp.VisibleCards.Length);
            for(int i = 0; i < p.VisibleCards.Length; ++i)
                CompareGameCard.Compare(p.VisibleCards[i],dp.VisibleCards[i]);

            Assert.AreEqual(p.State, dp.State);
            Assert.AreEqual(p.NoSeat, dp.NoSeat);
            Assert.AreEqual(p.Name, dp.Name);
            Assert.AreEqual(p.NbHiddenCards, dp.NbHiddenCards);
            Assert.AreEqual(p.MoneyBetAmnt, dp.MoneyBetAmnt);
            Assert.AreEqual(p.MoneySafeAmnt, dp.MoneySafeAmnt);
        }
    }
}
