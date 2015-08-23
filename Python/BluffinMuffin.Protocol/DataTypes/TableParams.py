from DataTypes.BlindOptions import BlindOptionsDecoder
from DataTypes.ConfigurableWaitingTimes import ConfigurableWaitingTimes
from DataTypes.Enums.GameTypeEnum import GameTypeEnum
from DataTypes.LimitOptions import LimitOptionsDecoder
from DataTypes.LobbyOptions import LobbyOptionsDecoder

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'


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
