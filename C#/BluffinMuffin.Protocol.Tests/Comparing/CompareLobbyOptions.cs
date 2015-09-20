using BluffinMuffin.Protocol.DataTypes.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BluffinMuffin.Protocol.Tests.Comparing
{
    public static class CompareLobbyOptions
    {
        public static void Compare(LobbyOptions l, LobbyOptions dl)
        {
            Assert.AreEqual(l.GetType(), dl.GetType());

            if (l.GetType() == typeof (LobbyOptionsRegisteredMode))
            {
                var lc = (LobbyOptionsRegisteredMode)l;
                var dlc = (LobbyOptionsRegisteredMode)dl;
                Assert.AreEqual(lc.IsMaximumBuyInLimited, dlc.IsMaximumBuyInLimited);
            }
            else if (l.GetType() == typeof(LobbyOptionsQuickMode))
            {
                var lt = (LobbyOptionsQuickMode)l;
                var dlt = (LobbyOptionsQuickMode)dl;
                Assert.AreEqual(lt.StartingAmount, dlt.StartingAmount);
            }
        }
    }
}
