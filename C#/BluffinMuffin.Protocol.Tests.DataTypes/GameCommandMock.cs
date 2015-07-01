using System.Collections.Generic;
using BluffinMuffin.Protocol.DataTypes.Enums;
using BluffinMuffin.Protocol.Game;

namespace BluffinMuffin.Protocol.Tests.DataTypes
{
    public static class GameCommandMock
    {
        public static BetTurnEndedCommand BetTurnEndedCommand()
        {
            return new BetTurnEndedCommand() {TableId = 42, PotsAmounts = new List<int>() {5, 10, 15, 20}, Round = RoundTypeEnum.River};
        }

        public static BetTurnStartedCommand BetTurnStartedCommand()
        {
            return new BetTurnStartedCommand() {TableId = 42, Cards = new[] {"2s", "5h", "Jd", "Ac"}, Round = RoundTypeEnum.River};
        }

        public static GameEndedCommand GameEndedCommand()
        {
            return new GameEndedCommand() {TableId = 42};
        }

        public static GameStartedCommand GameStartedCommand()
        {
            return new GameStartedCommand() {TableId = 42, NeededBlindAmount = 84};
        }

        public static PlayerHoleCardsChangedCommand PlayerHoleCardsChangedCommand()
        {
            return new PlayerHoleCardsChangedCommand() { TableId = 42, Cards = new[] { "2s", "5h" }, NoSeat = 7, PlayerState = PlayerStateEnum.Playing };
        }

        public static PlayerJoinedCommand PlayerJoinedCommand()
        {
            return new PlayerJoinedCommand() { TableId = 42, PlayerName = "SpongeBob" };
        }

        public static PlayerLeftCommand PlayerLeftCommand()
        {
            return new PlayerLeftCommand() { TableId = 42, PlayerName = "SpongeBob" };
        }

        public static PlayerPlayMoneyCommand PlayerPlayMoneyCommand()
        {
            return new PlayerPlayMoneyCommand() {TableId = 42, AmountPlayed = 84};
        }

        public static PlayerSitInCommand PlayerSitInCommand()
        {
            return new PlayerSitInCommand() {TableId = 42, NoSeat = 7, MoneyAmount = 84};
        }

        public static PlayerSitInResponse PlayerSitInResponse()
        {
            var response = PlayerSitInCommand().ResponseSuccess();
            response.NoSeat = 7;
            return response;
        }

        public static PlayerSitOutCommand PlayerSitOutCommand()
        {
            return new PlayerSitOutCommand() {TableId = 42};
        }

        public static PlayerSitOutResponse PlayerSitOutResponse()
        {
            return PlayerSitOutCommand().ResponseSuccess();
        }

        public static PlayerTurnBeganCommand PlayerTurnBeganCommand()
        {
            return new PlayerTurnBeganCommand() {TableId = 42, NoSeat = 7, MinimumRaiseAmount = 84};
        }

        public static PlayerTurnEndedCommand PlayerTurnEndedCommand()
        {
            return new PlayerTurnEndedCommand() {TableId = 42, NoSeat = 7, TotalPlayedMoneyAmount = 21, TotalSafeMoneyAmount = 84, TotalPot = 126, ActionTakenType = GameActionEnum.Raise, ActionTakenAmount = 63, PlayerState = PlayerStateEnum.AllIn};
        }

        public static PlayerWonPotCommand PlayerWonPotCommand()
        {
            return new PlayerWonPotCommand() { TableId = 42, NoSeat = 7, WonAmount = 210, TotalPlayerMoney = 84, TotalPotAmount = 420, PotId = 3, WinningCards = new[] { "5s", "5c", "5d", "Ad", "Ks" }, WinningHand = PokerHandEnum.ThreeOfAKind };
        }

        public static SeatUpdatedCommand SeatUpdatedCommand()
        {
            return new SeatUpdatedCommand() {TableId = 42, Seat = SeatInfoMock.SeatSeven()};
        }

        public static TableClosedCommand TableClosedCommand()
        {
            return new TableClosedCommand() {TableId = 42};
        }

        public static TableInfoCommand TableInfoCommand()
        {
            return new TableInfoCommand() { TableId = 42, Params = TableParamsMock.ParamsOne(), TotalPotAmount = 126, PotsAmount = new List<int>() { 5, 10, 15, 20 }, BoardCards = new[] { "2s", "5h", "Jd", "Ac" }, Seats = SeatInfoMock.AllSeats(), GameHasStarted = true };
        }
    }
}