using System.Collections.Generic;
using BluffinMuffin.Protocol.DataTypes;
using BluffinMuffin.Protocol.DataTypes.Enums;
using BluffinMuffin.Protocol.DataTypes.Options;
using BluffinMuffin.Protocol.Game;

namespace BluffinMuffin.Protocol.Tests.DataTypes
{
    public static class GameCommandMock
    {
        public static BetTurnEndedCommand BetTurnEndedCommand()
        {
            return new BetTurnEndedCommand() {TableId = 42, PotsAmounts = new List<int>() {5, 10, 15, 20}};
        }

        public static BetTurnStartedCommand BetTurnStartedCommand()
        {
            return new BetTurnStartedCommand() { TableId = 42, Cards = new[] { "2s", "5h", "Jd", "Ac" }, BettingRoundId = 4, Seats = SeatInfoMock.AllSeats() };
        }

        public static DiscardRoundStartedCommand DiscardRoundStartedCommand()
        {
            return new DiscardRoundStartedCommand() { TableId = 42, MinimumCardsToDiscard = 0, MaximumCardsToDiscard = 5 };
        }

        public static DiscardRoundEndedCommand DiscardRoundEndedCommand()
        {
            return new DiscardRoundEndedCommand() { TableId = 42, CardsDiscarded = new[] { new DiscardInfo() { NbCardsDiscarded = 3, NoSeat = 1 }, new DiscardInfo() { NbCardsDiscarded = 2, NoSeat =1 } } };
        }

        public static GameEndedCommand GameEndedCommand()
        {
            return new GameEndedCommand() {TableId = 42};
        }

        public static GameStartedCommand GameStartedCommand()
        {
            return new GameStartedCommand() {TableId = 42, NeededBlindAmount = 84, Seats = SeatInfoMock.AllSeats()};
        }

        public static PlayerHoleCardsChangedCommand PlayerHoleCardsChangedCommand()
        {
            return new PlayerHoleCardsChangedCommand() { TableId = 42, FaceUpCards = new[] { "2s", "5h" }, FaceDownCards = new[] { "??", "??" }, NoSeat = 7, PlayerState = PlayerStateEnum.Playing };
        }

        public static GameMessageCommand GameMessageCommandPlayerJoined()
        {
            return new GameMessageCommand { TableId = 42, Info = new GameMessageOptionPlayerJoined { PlayerName = "SpongeBob" } };
        }

        public static GameMessageCommand GameMessageCommandPlayerLeft()
        {
            return new GameMessageCommand { TableId = 42, Info = new GameMessageOptionPlayerLeft { PlayerName = "SpongeBob" } };
        }

        public static GameMessageCommand GameMessageCommandStudBringIn()
        {
            return new GameMessageCommand { TableId = 42, Info = new GameMessageOptionsStudBringIn {Cards = new[] { "2s", "5h" }, LowestHand = PokerHandEnum.HighCard, PlayerName = "SpongeBob"} };
        }

        public static GameMessageCommand GameMessageCommandStudHighestHand()
        {
            return new GameMessageCommand { TableId = 42, Info = new GameMessageOptionsStudHighestHand { Cards = new[] { "2s", "5h" }, HighestHand = PokerHandEnum.HighCard, PlayerName = "SpongeBob" } };
        }

        public static GameMessageCommand GameMessageCommandRaisingCapped()
        {
            return new GameMessageCommand { TableId = 42, Info = new GameMessageOptionsRaisingCapped() };
        }

        public static GameMessageCommand GameMessageCommandGeneralInformation()
        {
            return new GameMessageCommand { TableId = 42, Info = new GameMessageOptionGeneralInformation {Message="This is an important message from the server !!!"} };
        }

        public static PlayerPlayMoneyCommand PlayerPlayMoneyCommand()
        {
            return new PlayerPlayMoneyCommand() { TableId = 42, AmountPlayed = 84 };
        }

        public static PlayerDiscardActionCommand PlayerDiscardActionCommand()
        {
            return new PlayerDiscardActionCommand() { TableId = 42, CardsDiscarded = new[] { "2s", "5h" } };
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
            return new PlayerTurnBeganCommand() {TableId = 42, NoSeat = 7, MinimumRaiseAmount = 84, MaximumRaiseAmount = 4200};
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
    }
}