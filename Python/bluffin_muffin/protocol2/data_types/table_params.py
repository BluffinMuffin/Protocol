from collections import OrderedDict

from data_types.blind_options import BlindOptionsDecoder
from data_types.configurable_waiting_times import ConfigurableWaitingTimes
from game_type_enum import GameTypeEnum
from data_types.limit_options import LimitOptionsDecoder
from data_types.lobby_options import LobbyOptionsDecoder

__author__ = 'ericmas001@gmail.com'



class TableParams:
    def __init__(self, obj):
        self.table_name = obj['TableName']
        self.game_type = GameTypeEnum.parse(obj['GameType'])
        self.variant = obj['Variant']
        self.min_players_to_start = obj['MinPlayersToStart']
        self.max_players = obj['MaxPlayers']
        self.waiting_times = ConfigurableWaitingTimes(obj['WaitingTimes'])
        self.money_unit = obj['MoneyUnit']
        self.lobby = LobbyOptionsDecoder.decode(obj['Lobby'])
        self.blind = BlindOptionsDecoder.decode(obj['Blind'])
        self.limit = LimitOptionsDecoder.decode(obj['Limit'])

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