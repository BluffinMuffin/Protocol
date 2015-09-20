using System.Collections.Generic;
using BluffinMuffin.Protocol.DataTypes;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.Tests.DataTypes
{
    public static class GameInfoMock
    {
        public static IEnumerable<GameInfo> GetAllGames()
        {
            return new[]
                {
                    new GameInfo
                    {
                        GameType = GameTypeEnum.CommunityCardsPoker,
                        MinPlayers = 2,
                        MaxPlayers = 10,
                        AvailableLimits = new []{LimitTypeEnum.NoLimit,LimitTypeEnum.FixedLimit,LimitTypeEnum.PotLimit },
                        AvailableBlinds = new []{BlindTypeEnum.Blinds},
                        AvailableVariants = new [] {GameSubTypeEnum.TexasHoldem, GameSubTypeEnum.OmahaHoldem, GameSubTypeEnum.Pineapple, GameSubTypeEnum.CrazyPineapple, GameSubTypeEnum.LazyPineapple, GameSubTypeEnum.ThreeCardsHoldem, GameSubTypeEnum.IrishPoker }
                    },
                    new GameInfo
                    {
                        GameType = GameTypeEnum.StudPoker,
                        MinPlayers = 2,
                        MaxPlayers = 8,
                        AvailableLimits = new []{LimitTypeEnum.FixedLimit },
                        AvailableBlinds = new []{BlindTypeEnum.Antes},
                        AvailableVariants = new [] {GameSubTypeEnum.FiveCardsStud, GameSubTypeEnum.SevenCardsStud }
                    },
                    new GameInfo
                    {
                        GameType = GameTypeEnum.CommunityCardsPoker,
                        MinPlayers = 2,
                        MaxPlayers = 5,
                        AvailableLimits = new []{LimitTypeEnum.NoLimit,LimitTypeEnum.FixedLimit },
                        AvailableBlinds = new []{BlindTypeEnum.Antes, BlindTypeEnum.None },
                        AvailableVariants = new [] {GameSubTypeEnum.FiveCardsDraw }
                    },
                };
        }
    }
}
