from bluffinmuffin.protocol.data_types import *


def game_info_obj():
    return GameInfo(GameTypeEnum.CommunityCardsPoker,
                    [GameSubTypeEnum.TexasHoldem,GameSubTypeEnum.OmahaHoldem, GameSubTypeEnum.CrazyPineapple],
                    [LimitTypeEnum.NoLimit, LimitTypeEnum.FixedLimit, LimitTypeEnum.PotLimit],
                    [BlindTypeEnum.Blinds, BlindTypeEnum.Antes, BlindTypeEnum.Nothing],
                    2, 10)


def tuple_table1_obj():
    return TupleTable(42, 6, LobbyActionEnum.Join, table_params1_obj())


def tuple_table2_obj():
    return TupleTable(84, 3, LobbyActionEnum.Leave, table_params2_obj())


def discard_info_obj():
    return DiscardInfo(7, 3)


def configurable_waiting_times_obj():
    return ConfigurableWaitingTimes(500, 500, 2500)


def table_params1_obj():
    return TableParams("Bikini Bottom", GameSubTypeEnum.TexasHoldem, 2, 10, configurable_waiting_times_obj(),
                       10, lobby_option_obj(), BlindTypeEnum.Blinds, LimitTypeEnum.NoLimit, "", game_type_option_obj())


def table_params2_obj():
    return TableParams("Pokemon World", GameSubTypeEnum.TexasHoldem, 2, 10, configurable_waiting_times_obj(),
                       10, lobby_option_obj(), BlindTypeEnum.Antes, LimitTypeEnum.NoLimit, "", game_type_option_obj())


def game_type_option_obj():
    return GameTypeOptionsCommunity()


def lobby_option_obj():
    return LobbyOptionsQuickMode(1500)


def player_info_obj():
    return PlayerInfo(7, "SpongeBob", 1000, 42, ["2s", "Ah"], ["??", "??"], PlayerStateEnum.Playing)


def seat_info_obj():
    return SeatInfo(7, player_info_obj(), [SeatAttributeEnum.CurrentPlayer, SeatAttributeEnum.BigBlind])

def empty_seat_info_obj():
    return SeatInfo(8, None, [SeatAttributeEnum.SmallBlind])
