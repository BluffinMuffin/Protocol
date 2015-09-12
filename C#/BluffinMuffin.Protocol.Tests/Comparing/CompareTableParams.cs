using BluffinMuffin.Protocol.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BluffinMuffin.Protocol.Tests.Comparing
{
    public static class CompareTableParams
    {
        public static void Compare(TableParams t, TableParams dt)
        {
            Assert.AreEqual(t.GetType(), dt.GetType());

            Assert.AreEqual(t.GameSize, dt.GameSize);
            Assert.AreEqual(t.MaxPlayers, dt.MaxPlayers);
            Assert.AreEqual(t.MinPlayersToStart, dt.MinPlayersToStart);
            Assert.AreEqual(t.TableName, dt.TableName);
            Assert.AreEqual(t.Variant, dt.Variant);
            Assert.AreEqual(t.Blind, dt.Blind);
            Assert.AreEqual(t.Limit, dt.Limit);
            Assert.AreEqual(t.Arguments, dt.Arguments);
            CompareGameTypeOptions.Compare(t.Options, dt.Options);
            CompareLobbyOptions.Compare(t.Lobby, dt.Lobby);
            CompareConfigurableWaitingTimes.Compare(t.WaitingTimes, dt.WaitingTimes);
        }
    }
}
