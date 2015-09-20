from collections import OrderedDict

from bluffinmuffin.protocol.enums import GameTypeEnum


class GameTypeOptions:
    def __init__(self, option_type):
        self.option_type = option_type

    def __str__(self):
        return GameTypeEnum.to_string(self.option_type)

    def _encode_specific(self, d):
        return None

    def _encode_specific_end(self, d):
        return None

    def encode(self):
        d = OrderedDict()
        d['OptionType'] = GameTypeEnum.to_string(self.option_type)
        self._encode_specific(d)
        self._encode_specific_end(d)
        return d


class GameTypeOptionsCommunity(GameTypeOptions):
    def __init__(self):
        super().__init__(GameTypeEnum.CommunityCardsPoker)

    @classmethod
    def decode(cls, obj):
        return cls()


class GameTypeOptionsDraw(GameTypeOptions):
    def __init__(self):
        super().__init__(GameTypeEnum.DrawPoker)

    @classmethod
    def decode(cls, obj):
        return cls()


class GameTypeOptionsStud(GameTypeOptions):
    def __init__(self):
        super().__init__(GameTypeEnum.StudPoker)

    @classmethod
    def decode(cls, obj):
        return cls()


class GameTypeOptionsDecoder():
    @classmethod
    def decode(cls, obj):
        type = GameTypeEnum.parse(obj['OptionType'])
        if type == GameTypeEnum.CommunityCardsPoker:
            return GameTypeOptionsCommunity.decode(obj)
        if type == GameTypeEnum.DrawPoker:
            return GameTypeOptionsDraw.decode(obj)
        if type == GameTypeEnum.StudPoker:
            return GameTypeOptionsStud.decode(obj)
        return None
