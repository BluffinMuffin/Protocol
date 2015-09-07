from collections import OrderedDict
import sys

from bluffinmuffin.protocol.enums import LobbyTypeEnum


class LobbyOptions:
    def __init__(self, option_type):
        self.option_type = option_type

    def __str__(self):
        return LobbyTypeEnum.to_string(self.option_type)

    def _encode_specific(self, d):
        return None

    def _encode_specific_end(self, d):
        return None

    def encode(self):
        d = OrderedDict()
        d['OptionType'] = LobbyTypeEnum.to_string(self.option_type)
        self._encode_specific(d)
        self._encode_specific_end(d)
        return d


class LobbyOptionsQuickMode(LobbyOptions):
    def __init__(self, starting_amount):
        super().__init__(LobbyTypeEnum.QuickMode)
        self.starting_amount = starting_amount
        self.minimum_amount_for_buy_in = self.starting_amount
        self.maximum_amount_for_buy_in = self.starting_amount

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['StartingAmount'] = self.starting_amount

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['StartingAmount']
        )


class LobbyOptionsRegisteredMode(LobbyOptions):
    def __init__(self, money_unit, is_maximum_buy_in_limited):
        super().__init__(LobbyTypeEnum.RegisteredMode)
        self.money_unit = money_unit
        self.is_maximum_buy_in_limited = is_maximum_buy_in_limited
        self.minimum_amount_for_buy_in = self.money_unit * 20
        if self.is_maximum_buy_in_limited:
            self.maximum_amount_for_buy_in = sys.maxsize
        else:
            self.maximum_amount_for_buy_in = self.money_unit * 100

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['MoneyUnit'] = self.money_unit
        d['IsMaximumBuyInLimited'] = self.is_maximum_buy_in_limited

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['MoneyUnit'],
            obj['IsMaximumBuyInLimited']
        )


class LobbyOptionsDecoder():
    @classmethod
    def decode(cls, obj):
        type = LobbyTypeEnum.parse(obj['OptionType'])
        if type == LobbyTypeEnum.QuickMode:
            return LobbyOptionsQuickMode.decode(obj)
        if type == LobbyTypeEnum.RegisteredMode:
            return LobbyOptionsRegisteredMode.decode(obj)
        return None
