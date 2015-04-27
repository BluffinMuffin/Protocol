using BluffinMuffin.Protocol.Lobby.QuickMode;
using BluffinMuffin.Protocol.Tests.Helpers;
using BluffinMuffin.Protocol.Tests.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BluffinMuffin.Protocol.Tests
{
    [TestClass]
    public class LobbyQuickModeCommandsDecodeTest
    {

        [TestMethod]
        public void IdentifyCommand()
        {
            var c = LobbyCommandMock.IdentifyCommand();
            var dc = EncodeDecodeHelper.GetDecodedCommand(c);
            CompareIdentifyCommand(c, dc);
        }

        [TestMethod]
        public void IdentifyResponse()
        {
            var c = LobbyCommandMock.IdentifyResponse();
            var dc = EncodeDecodeHelper.GetDecodedCommand(c);
            Assert.AreEqual(c.Success, dc.Success);
            CompareIdentifyCommand(c.Command, dc.Command);
        }

        private static void CompareIdentifyCommand(IdentifyCommand c, IdentifyCommand dc)
        {
            Assert.AreEqual(c.Name, dc.Name);
        }
    }
}
