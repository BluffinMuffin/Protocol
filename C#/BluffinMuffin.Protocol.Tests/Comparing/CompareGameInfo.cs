using System.Linq;
using BluffinMuffin.Protocol.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BluffinMuffin.Protocol.Tests.Comparing
{
    public static class CompareGameInfo
    {
        public static void Compare(GameInfo g, GameInfo dg)
        {
            Assert.IsFalse(g.AvailableBlinds.Except(dg.AvailableBlinds).Any());
            Assert.IsFalse(g.AvailableLimits.Except(dg.AvailableLimits).Any());
            Assert.IsFalse(g.AvailableVariants.Except(dg.AvailableVariants).Any());
            Assert.AreEqual(g.AvailableBlinds.Length, dg.AvailableBlinds.Length);
            Assert.AreEqual(g.AvailableLimits.Length, dg.AvailableLimits.Length);
            Assert.AreEqual(g.AvailableVariants.Length, dg.AvailableVariants.Length);
            Assert.AreEqual(g.GameType, dg.GameType);
            Assert.AreEqual(g.MaxPlayers, dg.MaxPlayers);
            Assert.AreEqual(g.MinPlayers, dg.MinPlayers);
        }
    }
}
