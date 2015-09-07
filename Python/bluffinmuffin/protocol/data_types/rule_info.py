from collections import OrderedDict

from bluffinmuffin.protocol.enums import BlindTypeEnum
from bluffinmuffin.protocol.enums import GameTypeEnum
from bluffinmuffin.protocol.enums import LimitTypeEnum
from bluffinmuffin.protocol.enums import LobbyTypeEnum


class RuleInfo:
    def __init__(self, game_type, name, min_players, max_players, available_limits, default_limit, available_blinds,
                 default_blind, can_config_waiting_time, available_lobbys):
        self.game_type = game_type
        self.name = name
        self.min_players = min_players
        self.max_players = max_players
        self.available_limits = available_limits
        self.default_limit = default_limit
        self.available_blinds = available_blinds
        self.default_blind = default_blind
        self.can_config_waiting_time = can_config_waiting_time
        self.available_lobbys = available_lobbys

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
            self.can_config_waiting_time,
            ', '.join([LimitTypeEnum.to_string(x) for x in self.available_lobbys])
        )

    def encode(self):
        d = OrderedDict()
        d['GameType'] = GameTypeEnum.to_string(self.game_type)
        d['Name'] = self.name
        d['MinPlayers'] = self.min_players
        d['MaxPlayers'] = self.max_players
        d['AvailableLimits'] = [LimitTypeEnum.to_string(x) for x in self.available_limits]
        d['DefaultLimit'] = LimitTypeEnum.to_string(self.default_limit)
        d['AvailableBlinds'] = [BlindTypeEnum.to_string(x) for x in self.available_blinds]
        d['DefaultBlind'] = BlindTypeEnum.to_string(self.default_blind)
        d['CanConfigWaitingTime'] = self.can_config_waiting_time
        d['AvailableLobbys'] = [LobbyTypeEnum.to_string(x) for x in self.available_lobbys]
        return d

    @classmethod
    def decode(cls, obj):
        return cls(
            GameTypeEnum.parse(obj['GameType']),
            obj['Name'],
            obj["MinPlayers"],
            obj["MaxPlayers"],
            [LimitTypeEnum.parse(x) for x in obj['AvailableLimits']],
            LimitTypeEnum.parse(obj['DefaultLimit']),
            [BlindTypeEnum.parse(x) for x in obj['AvailableBlinds']],
            BlindTypeEnum.parse(obj['DefaultBlind']),
            obj['CanConfigWaitingTime'],
            [LobbyTypeEnum.parse(x) for x in obj['AvailableLobbys']]
        )
