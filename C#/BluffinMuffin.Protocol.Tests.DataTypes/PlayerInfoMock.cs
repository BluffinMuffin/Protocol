using BluffinMuffin.Protocol.DataTypes;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.Tests.DataTypes
{

    public static class PlayerInfoMock
    {
        public static PlayerInfo Dora()
        {
            return new PlayerInfo()
            {
                State = PlayerStateEnum.Playing,
                NoSeat = 7,
                Name = "Dora",
                Cards = new[] { GameCardMock.AceOfClubs(), GameCardMock.JackOfHearts() },
                NbHiddenCards = 3,
                MoneyBetAmnt = 84,
                MoneySafeAmnt = 126
            };
        }

        public static PlayerInfo Diego()
        {
            return new PlayerInfo()
            {
                State = PlayerStateEnum.Zombie,
                NoSeat = 6,
                Name = "Diego",
                Cards = new[] { GameCardMock.TenOfDiamonds(), GameCardMock.TwoOfSpades() },
                NbHiddenCards = 3,
                MoneyBetAmnt = 21,
                MoneySafeAmnt = 63
            };
        }
    }
}
