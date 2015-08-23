from collections import OrderedDict
import sys

from lobby_type_enum import LobbyTypeEnum

__author__ = 'ericmas001@gmail.com'



class LobbyOptions:
    def __init__(self, obj):
        self.option_type = LobbyTypeEnum.parse(obj['OptionType'])

    def __str__(self):
        return LobbyTypeEnum.to_string(self.option_type)

    def encode(self, d):
        d['OptionType'] = LobbyTypeEnum.to_string(self.option_type)

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
    def __init__(self, obj):
        super().__init__(obj)
        self.starting_amount = obj['StartingAmount']
        self.minimum_amount_for_buy_in = self.starting_amount
        self.maximum_amount_for_buy_in = self.starting_amount

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['StartingAmount'] = self.starting_amount

class LobbyOptionsRegisteredMode(LobbyOptions):
    def __init__(self, obj):
        super().__init__(obj)
        self.money_unit = obj['MoneyUnit']
        self.is_maximum_buy_in_limited = obj['IsMaximumBuyInLimited']
        self.minimum_amount_for_buy_in = self.money_unit * 20
        if self.is_maximum_buy_in_limited:
            self.maximum_amount_for_buy_in = sys.maxsize
        else:
            self.maximum_amount_for_buy_in = self.money_unit * 100

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['MoneyUnit'] = self.money_unit
        d['IsMaximumBuyInLimited'] = self.is_maximum_buy_in_limited


class LobbyOptionsDecoder():
    @classmethod
    def decode(cls, obj):
        type = LobbyTypeEnum.parse(obj['OptionType'])
        if type == LobbyTypeEnum.QuickMode:
            return LobbyOptionsQuickMode(obj)
        if type == LobbyTypeEnum.RegisteredMode:
            return LobbyOptionsRegisteredMode(obj)
        return None
