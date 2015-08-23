from data_types.blind_options import BlindOptionsDecoder
from data_types.configurable_waiting_times import ConfigurableWaitingTimes
from data_types.enums.blind_type_enum import BlindTypeEnum
from data_types.enums.game_type_enum import GameTypeEnum
from data_types.enums.limit_type_enum import LimitTypeEnum
from data_types.enums.lobby_type_enum import LobbyTypeEnum
from data_types.limit_options import LimitOptionsDecoder
from data_types.lobby_options import LobbyOptionsDecoder

__author__ = 'ericmas001@gmail.com'



class RuleInfo:
    def __init__(self, obj):
        self.game_type = GameTypeEnum.parse(obj['GameType'])
        self.name = obj['Name']
        self.min_players = obj['MinPlayers']
        self.max_players = obj['MaxPlayers']
        self.available_limits = [LimitTypeEnum.parse(x) for x in obj['AvailableLimits']]
        self.default_limit = LimitTypeEnum.parse(obj['DefaultLimit'])
        self.available_blinds = [BlindTypeEnum.parse(x) for x in obj['AvailableBlinds']]
        self.default_blind = BlindTypeEnum.parse(obj['DefaultBlind'])
        self.can_configure_waiting_time = obj['CanConfigWaitingTime']
        self.available_lobbys = [LobbyTypeEnum.parse(x) for x in obj['AvailableLobbys']]

    def __str__(self):
        return '"{0}", {1}, {2}/{3}, ({5}: {4}), ({7}: {6}), {8}, ({9})'.format(
            self.name,
            GameTypeEnum.to_string(self.game_type),
            self.min_players,
            self.max_players,
            ', '.join([LimitTypeEnum.to_string(x) for x in self.available_limits]),
            self.default_limit,
            ', '.join([BlindTypeEnum.to_string(x) for x in self.available_blinds]),
            self.default_blind,
            self.can_configure_waiting_time,
            ', '.join([LimitTypeEnum.to_string(x) for x in self.available_lobbys])
        )
