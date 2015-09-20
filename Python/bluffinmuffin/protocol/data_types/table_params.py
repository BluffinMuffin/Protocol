from collections import OrderedDict

from bluffinmuffin.protocol.enums import GameSubTypeEnum
from bluffinmuffin.protocol.enums import BlindTypeEnum
from bluffinmuffin.protocol.enums import LimitTypeEnum
from .configurable_waiting_times import ConfigurableWaitingTimes
from .lobby_options import LobbyOptionsDecoder
from .game_type_options import GameTypeOptionsDecoder


class TableParams:
    def __init__(self, table_name, variant, min_players_to_start, max_players, waiting_times, game_size,
                 lobby, blind, limit, arguments, options):
        self.table_name = table_name
        self.variant = variant
        self.min_players_to_start = min_players_to_start
        self.max_players = max_players
        self.waiting_times = waiting_times
        self.game_size = game_size
        self.arguments = arguments
        self.lobby = lobby
        self.blind = blind
        self.limit = limit
        self.arguments = arguments
        self.options = options

    def __str__(self):
        return '"{0}", {1}, {2}/{3}, {5}, {6}, {7}, {8}, {9}, {10}'.format(
            self.table_name,
            GameSubTypeEnum.to_string(self.variant),
            self.min_players_to_start,
            self.max_players,
            self.waiting_times,
            self.game_size,
            self.arguments,
            self.lobby,
            BlindTypeEnum.to_string(self.blind),
            LimitTypeEnum.to_string(self.limit),
            self.options
        )

    def encode(self):
        d = OrderedDict()
        d['TableName'] = self.table_name
        d['Variant'] = GameSubTypeEnum.to_string(self.variant)
        d['MinPlayersToStart'] = self.min_players_to_start
        d['MaxPlayers'] = self.max_players
        d['WaitingTimes'] = self.waiting_times.encode()
        d['GameSize'] = self.game_size
        d['Lobby'] = self.lobby.encode()
        d['Blind'] = BlindTypeEnum.to_string(self.blind)
        d['Limit'] = LimitTypeEnum.to_string(self.limit)
        d['Arguments'] = self.arguments
        d['Options'] = self.options.encode()
        return d

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableName"],
            GameSubTypeEnum.parse(obj['Variant']),
            obj["MinPlayersToStart"],
            obj["MaxPlayers"],
            ConfigurableWaitingTimes.decode(obj['WaitingTimes']),
            obj["GameSize"],
            LobbyOptionsDecoder.decode(obj['Lobby']),
            BlindTypeEnum.parse(obj['Blind']),
            LimitTypeEnum.parse(obj['Limit']),
            obj["Arguments"],
            GameTypeOptionsDecoder.decode(obj['Options']),
        )
