from collections import OrderedDict

from bluffinmuffin.protocol.enums import BlindTypeEnum
from bluffinmuffin.protocol.enums import GameTypeEnum
from bluffinmuffin.protocol.enums import LimitTypeEnum
from bluffinmuffin.protocol.enums import GameSubTypeEnum


class GameInfo:
    def __init__(self, game_type, available_variants, available_limits, available_blinds, min_players, max_players):
        self.game_type = game_type
        self.available_variants = available_variants
        self.available_limits = available_limits
        self.available_blinds = available_blinds
        self.min_players = min_players
        self.max_players = max_players

    def __str__(self):
        return '{0}, [{1}], {2}/{3}, ({4}), ({5})'.format(
            GameTypeEnum.to_string(self.game_type),
            ', '.join([GameSubTypeEnum.to_string(x) for x in self.available_variants]),
            self.min_players,
            self.max_players,
            ', '.join([LimitTypeEnum.to_string(x) for x in self.available_limits]),
            ', '.join([BlindTypeEnum.to_string(x) for x in self.available_blinds])
        )

    def encode(self):
        d = OrderedDict()
        d['GameType'] = GameTypeEnum.to_string(self.game_type)
        d['AvailableVariants'] = [GameSubTypeEnum.to_string(x) for x in self.available_variants]
        d['AvailableLimits'] = [LimitTypeEnum.to_string(x) for x in self.available_limits]
        d['AvailableBlinds'] = [BlindTypeEnum.to_string(x) for x in self.available_blinds]
        d['MinPlayers'] = self.min_players
        d['MaxPlayers'] = self.max_players
        return d

    @classmethod
    def decode(cls, obj):
        return cls(
            GameTypeEnum.parse(obj['GameType']),
            [GameSubTypeEnum.parse(x) for x in obj['AvailableVariants']],
            [LimitTypeEnum.parse(x) for x in obj['AvailableLimits']],
            [BlindTypeEnum.parse(x) for x in obj['AvailableBlinds']],
            obj["MinPlayers"],
            obj["MaxPlayers"]
        )
