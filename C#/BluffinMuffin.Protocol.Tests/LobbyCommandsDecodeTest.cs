using System.Linq;
using BluffinMuffin.Protocol.Lobby;
using BluffinMuffin.Protocol.Tests.Comparing;
using BluffinMuffin.Protocol.Tests.Helpers;
using BluffinMuffin.Protocol.Tests.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BluffinMuffin.Protocol.Tests
{
    [TestClass]
    public class LobbyCommandsDecodeTest
    {

        [TestMethod]
        public void CheckCompatibilityCommand()
        {
            var c = LobbyCommandMock.CheckCompatibilityCommand();
            var dc = EncodeDecodeHelper.GetDecodedCommand(c);
            CompareCheckCompatibilityCommand(c, dc);
        }

        [TestMethod]
        public void CheckCompatibilityResponse()
        {
            var c = LobbyCommandMock.CheckCompatibilityResponse();
            var dc = EncodeDecodeHelper.GetDecodedCommand(c);

            Assert.AreEqual(c.ImplementedProtocolVersion, dc.ImplementedProtocolVersion);
            Assert.IsFalse(c.SupportedLobbyTypes.Except(dc.SupportedLobbyTypes).Any());
            Assert.AreEqual(c.Rules.Length, dc.Rules.Length);
            for (int i = 0; i < c.Rules.Length; ++i)
                CompareRuleInfo.Compare(c.Rules[i], dc.Rules[i]);
            CompareCheckCompatibilityCommand(c.Command, dc.Command);
        }

        [TestMethod]
        public void ListTableCommand()
        {
            var c = LobbyCommandMock.ListTableCommand();
            var dc = EncodeDecodeHelper.GetDecodedCommand(c);
            CompareListTableCommand(c, dc);
        }

        [TestMethod]
        public void ListTableResponse()
        {
            var c = LobbyCommandMock.ListTableResponse();
            var dc = EncodeDecodeHelper.GetDecodedCommand(c);

            Assert.AreEqual(c.Tables.Count, dc.Tables.Count);
            for (int i = 0; i < c.Tables.Count; ++i)
                CompareTupleTable.Compare(c.Tables[i], dc.Tables[i]);
            CompareListTableCommand(c.Command, dc.Command);
        }

        [TestMethod]
        public void JoinTableCommand()
        {
            var c = LobbyCommandMock.JoinTableCommand();
            var dc = EncodeDecodeHelper.GetDecodedCommand(c);
            CompareJoinTableCommand(c, dc);
        }

        [TestMethod]
        public void JoinTableResponse()
        {
            var c = LobbyCommandMock.JoinTableResponse();
            var dc = EncodeDecodeHelper.GetDecodedCommand(c);

            Assert.AreEqual(c.Success, dc.Success);
            CompareJoinTableCommand(c.Command, dc.Command);
        }

        [TestMethod]
        public void LeaveTableCommand()
        {
            var c = LobbyCommandMock.LeaveTableCommand();
            var dc = EncodeDecodeHelper.GetDecodedCommand(c);
            CompareLeaveTableCommand(c, dc);
        }

        [TestMethod]
        public void CreateTableCommand()
        {
            var c = LobbyCommandMock.CreateTableCommand();
            var dc = EncodeDecodeHelper.GetDecodedCommand(c);
            CompareCreateTableCommand(c, dc);
        }

        [TestMethod]
        public void CreateTableResponse()
        {
            var c = LobbyCommandMock.CreateTableResponse();
            var dc = EncodeDecodeHelper.GetDecodedCommand(c);

            Assert.AreEqual(c.IdTable, dc.IdTable);
            CompareCreateTableCommand(c.Command, dc.Command);
        }

        private static void CompareCheckCompatibilityCommand(CheckCompatibilityCommand c, CheckCompatibilityCommand dc)
        {
            Assert.AreEqual(c.ImplementedProtocolVersion,dc.ImplementedProtocolVersion);
        }

        private static void CompareListTableCommand(ListTableCommand c, ListTableCommand dc)
        {
            Assert.IsFalse(c.LobbyTypes.Except(dc.LobbyTypes).Any());
            Assert.AreEqual(c.LobbyTypes.Length, dc.LobbyTypes.Length);
        }

        private static void CompareJoinTableCommand(JoinTableCommand c, JoinTableCommand dc)
        {
            Assert.AreEqual(c.TableId, dc.TableId);
        }

        private void CompareLeaveTableCommand(LeaveTableCommand c, LeaveTableCommand dc)
        {
            Assert.AreEqual(c.TableId, dc.TableId);
        }

        private static void CompareCreateTableCommand(CreateTableCommand c, CreateTableCommand dc)
        {
            CompareTableParams.Compare(c.Params, dc.Params);
        }
    }
}
