from collections import OrderedDict

from bluffinmuffin.protocol.enums import GameTypeEnum
from .blind_options import BlindOptionsDecoder
from .configurable_waiting_times import ConfigurableWaitingTimes
from .limit_options import LimitOptionsDecoder
from .lobby_options import LobbyOptionsDecoder


class TableParams:

    def __init__(self, table_name, game_type, variant, min_players_to_start, max_players, waiting_times, money_unit, lobby, blind, limit):
        self.table_name = table_name
        self.game_type = game_type
        self.variant = variant
        self.min_players_to_start = min_players_to_start
        self.max_players = max_players
        self.waiting_times = waiting_times
        self.money_unit = money_unit
        self.lobby = lobby
        self.blind = blind
        self.limit = limit

    def __str__(self):
        return '"{0}", {1}, "{2}", {3}/{4}, {5}, {6}, {7}, {8}, {9}'.format(
            self.table_name,
            GameTypeEnum.to_string(self.game_type),
            self.variant,
            self.min_players_to_start,
            self.max_players,
            self.waiting_times,
            self.money_unit,
            self.lobby,
            self.blind,
            self.limit
        )

    def encode(self):
        d = OrderedDict()
        d['TableName'] = self.table_name
        d['GameType'] = GameTypeEnum.to_string(self.game_type)
        d['Variant'] = self.variant
        d['MinPlayersToStart'] = self.min_players_to_start
        d['MaxPlayers'] = self.max_players
        d['WaitingTimes'] = self.waiting_times.encode()
        d['MoneyUnit'] = self.money_unit
        d['Lobby'] = self.lobby.encode()
        d['Blind'] = self.blind.encode()
        d['Limit'] = self.limit.encode()
        return d

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableName"],
            GameTypeEnum.parse(obj['GameType']),
            obj["Variant"],
            obj["MinPlayersToStart"],
            obj["MaxPlayers"],
            ConfigurableWaitingTimes.decode(obj['WaitingTimes']),
            obj["MoneyUnit"],
            LobbyOptionsDecoder.decode(obj['Lobby']),
            BlindOptionsDecoder.decode(obj['Blind']),
            LimitOptionsDecoder.decode(obj['Limit'])
        )
