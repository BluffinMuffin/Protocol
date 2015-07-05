using System.Linq;
using BluffinMuffin.Protocol.Game;
using BluffinMuffin.Protocol.Tests.Comparing;
using BluffinMuffin.Protocol.Tests.Helpers;
using BluffinMuffin.Protocol.Tests.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BluffinMuffin.Protocol.Tests
{
    [TestClass]
    public class GameCommandsDecodeTest
    {
        private T GetDecodedCommand<T>(T c) 
            where T : AbstractGameCommand
        {
            var dc = EncodeDecodeHelper.GetDecodedCommand(c);
            Assert.AreEqual(c.TableId, dc.TableId);
            return dc;
        }
        private T GetDecodedResponse<T, TC>(T c) 
            where T : AbstractBluffinReponse<TC>
            where TC : AbstractGameCommand
        {
            var dc = EncodeDecodeHelper.GetDecodedCommand(c);
            Assert.AreEqual(c.Command.TableId, dc.Command.TableId);
            return dc;
        }

        [TestMethod]
        public void BetTurnEndedCommand()
        {
            var c = GameCommandMock.BetTurnEndedCommand();
            var dc = GetDecodedCommand(c);
            Assert.AreEqual(c.PotsAmounts.Count, dc.PotsAmounts.Count);
            Assert.IsFalse(c.PotsAmounts.Except(dc.PotsAmounts).Any());
        }
        [TestMethod]
        public void BetTurnStartedCommand()
        {
            var c = GameCommandMock.BetTurnStartedCommand();
            var dc = GetDecodedCommand(c);
            Assert.AreEqual(c.BettingRoundId, dc.BettingRoundId);
            Assert.AreEqual(c.Cards.Length, dc.Cards.Length);
            Assert.IsFalse(c.Cards.Except(dc.Cards).Any());
        }
        [TestMethod]
        public void GameEndedCommand()
        {
            var c = GameCommandMock.GameEndedCommand();
            var dc = GetDecodedCommand(c);
        }
        [TestMethod]
        public void GameStartedCommand()
        {
            var c = GameCommandMock.GameStartedCommand();
            var dc = GetDecodedCommand(c);
            Assert.AreEqual(c.NeededBlindAmount, dc.NeededBlindAmount);
        }
        [TestMethod]
        public void PlayerHoleCardsChangedCommand()
        {
            var c = GameCommandMock.PlayerHoleCardsChangedCommand();
            var dc = GetDecodedCommand(c);
            Assert.AreEqual(c.NoSeat, dc.NoSeat);
            Assert.AreEqual(c.Cards.Length, dc.Cards.Length);
            Assert.IsFalse(c.Cards.Except(dc.Cards).Any());
            Assert.AreEqual(c.PlayerState, dc.PlayerState);
        }
        [TestMethod]
        public void PlayerJoinedCommand()
        {
            var c = GameCommandMock.PlayerJoinedCommand();
            var dc = GetDecodedCommand(c);
            Assert.AreEqual(c.PlayerName, dc.PlayerName);
        }
        [TestMethod]
        public void PlayerLeftCommand()
        {
            var c = GameCommandMock.PlayerLeftCommand();
            var dc = GetDecodedCommand(c);
            Assert.AreEqual(c.PlayerName, dc.PlayerName);
        }
        [TestMethod]
        public void PlayerPlayMoneyCommand()
        {
            var c = GameCommandMock.PlayerPlayMoneyCommand();
            var dc = GetDecodedCommand(c);
            Assert.AreEqual(c.AmountPlayed, dc.AmountPlayed);
        }
        [TestMethod]
        public void PlayerSitInCommand()
        {
            var c = GameCommandMock.PlayerSitInCommand();
            var dc = GetDecodedCommand(c);
            ComparePlayerSitInCommand(c, dc);
        }
        [TestMethod]
        public void PlayerSitInResponse()
        {
            var c = GameCommandMock.PlayerSitInResponse();
            var dc = GetDecodedResponse<PlayerSitInResponse, PlayerSitInCommand>(c);
            Assert.AreEqual(c.NoSeat, dc.NoSeat);
            ComparePlayerSitInCommand(c.Command, dc.Command);
        }

        [TestMethod]
        public void PlayerSitOutCommand()
        {
            var c = GameCommandMock.PlayerSitOutCommand();
            var dc = GetDecodedCommand(c);
            ComparePlayerSitOutCommand(c, dc);
        }
        [TestMethod]
        public void PlayerSitOutResponse()
        {
            var c = GameCommandMock.PlayerSitOutResponse();
            var dc = GetDecodedResponse<PlayerSitOutResponse, PlayerSitOutCommand>(c);
            Assert.AreEqual(c.Success, dc.Success);
            ComparePlayerSitOutCommand(c.Command, dc.Command);
        }
        [TestMethod]
        public void PlayerTurnBeganCommand()
        {
            var c = GameCommandMock.PlayerTurnBeganCommand();
            var dc = GetDecodedCommand(c);
            Assert.AreEqual(c.NoSeat, dc.NoSeat);
            Assert.AreEqual(c.MinimumRaiseAmount, dc.MinimumRaiseAmount);
        }
        [TestMethod]
        public void PlayerTurnEndedCommand()
        {
            var c = GameCommandMock.PlayerTurnEndedCommand();
            var dc = GetDecodedCommand(c);
            Assert.AreEqual(c.NoSeat, dc.NoSeat);
            Assert.AreEqual(c.TotalPlayedMoneyAmount, dc.TotalPlayedMoneyAmount);
            Assert.AreEqual(c.TotalSafeMoneyAmount, dc.TotalSafeMoneyAmount);
            Assert.AreEqual(c.TotalPot, dc.TotalPot);
            Assert.AreEqual(c.ActionTakenType, dc.ActionTakenType);
            Assert.AreEqual(c.ActionTakenAmount, dc.ActionTakenAmount);
            Assert.AreEqual(c.PlayerState, dc.PlayerState);
        }
        [TestMethod]
        public void PlayerWonPotCommand()
        {
            var c = GameCommandMock.PlayerWonPotCommand();
            var dc = GetDecodedCommand(c);
            Assert.AreEqual(c.NoSeat, dc.NoSeat);
            Assert.AreEqual(c.PotId, dc.PotId);
            Assert.AreEqual(c.TotalPlayerMoney, dc.TotalPlayerMoney);
            Assert.AreEqual(c.WonAmount, dc.WonAmount);
            Assert.AreEqual(c.TotalPotAmount, dc.TotalPotAmount);
            Assert.AreEqual(c.WinningHand, dc.WinningHand);
            Assert.AreEqual(c.WinningCards.Length, dc.WinningCards.Length);
            for (int i = 0; i < c.WinningCards.Length; ++i)
                Assert.AreEqual(c.WinningCards[i], dc.WinningCards[i]);
        }
        [TestMethod]
        public void SeatUpdatedCommand()
        {
            var c = GameCommandMock.SeatUpdatedCommand();
            var dc = GetDecodedCommand(c);
            CompareSeatInfo.Compare(c.Seat, dc.Seat);
        }
        [TestMethod]
        public void TableClosedCommand()
        {
            var c = GameCommandMock.TableClosedCommand();
            var dc = GetDecodedCommand(c);
        }
        [TestMethod]
        public void TableInfoCommand()
        {
            var c = GameCommandMock.TableInfoCommand();
            var dc = GetDecodedCommand(c);
            CompareTableParams.Compare(c.Params, dc.Params);
            Assert.AreEqual(c.TotalPotAmount, dc.TotalPotAmount);
            Assert.AreEqual(c.PotsAmount.Count, dc.PotsAmount.Count);
            Assert.IsFalse(c.PotsAmount.Except(dc.PotsAmount).Any());
            Assert.AreEqual(c.BoardCards.Length, dc.BoardCards.Length);
            Assert.IsFalse(c.BoardCards.Except(dc.BoardCards).Any());
            Assert.AreEqual(c.Seats.Count, dc.Seats.Count);
            for (int i = 0; i < c.Seats.Count; ++i)
                CompareSeatInfo.Compare(c.Seats[i], dc.Seats[i]);
            Assert.AreEqual(c.GameHasStarted, dc.GameHasStarted);
        }

        private static void ComparePlayerSitInCommand(PlayerSitInCommand c, PlayerSitInCommand dc)
        {
            Assert.AreEqual(c.NoSeat, dc.NoSeat);
            Assert.AreEqual(c.MoneyAmount, dc.MoneyAmount);
        }
        private static void ComparePlayerSitOutCommand(PlayerSitOutCommand c, PlayerSitOutCommand dc)
        {
        }
    }
}
