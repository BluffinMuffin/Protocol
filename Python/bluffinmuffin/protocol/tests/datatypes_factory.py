from bluffinmuffin.protocol.data_types import *


def rule_info_obj():
    return RuleInfo(GameTypeEnum.Holdem,"Texas Hold'em",2,10,[LimitTypeEnum.NoLimit],LimitTypeEnum.NoLimit,[BlindTypeEnum.Blinds,BlindTypeEnum.Antes,BlindTypeEnum.Nothing],BlindTypeEnum.Blinds,True,[LobbyTypeEnum.QuickMode,LobbyTypeEnum.RegisteredMode])


def tuple_table1_obj():
    return TupleTable(42,6,LobbyActionEnum.Join,table_params1_obj())

def tuple_table2_obj():
    return TupleTable(84,3,LobbyActionEnum.Leave,table_params2_obj())

def discard_info_obj():
    return DiscardInfo(7,3)

def configurable_waiting_times_obj():
    return ConfigurableWaitingTimes(500,500,2500)

def table_params1_obj():
    return TableParams("Bikini Bottom",GameTypeEnum.Holdem,"Texas Hold'em",2,10,configurable_waiting_times_obj(),10,lobby_option_obj(),blind_option_obj(),limit_option_obj())

def table_params2_obj():
    return TableParams("Pokemon World",GameTypeEnum.Holdem,"Texas Hold'em",2,10,configurable_waiting_times_obj(),10,lobby_option_obj(),antes_option_obj(),limit_option_obj())

def blind_option_obj():
    return BlindOptionsBlinds(10)

def antes_option_obj():
    return BlindOptionsAnte(10)

def lobby_option_obj():
    return LobbyOptionsQuickMode(1500)

def limit_option_obj():
    return LimitOptionsNoLimit()

def player_info_obj():
    return PlayerInfo(7,"SpongeBob",1000,42,["2s", "Ah"],PlayerStateEnum.Playing,True)

def seat_info_obj():
    return SeatInfo(7,player_info_obj(),[SeatAttributeEnum.CurrentPlayer,SeatAttributeEnum.BigBlind])