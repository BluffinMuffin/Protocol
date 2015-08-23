import sys
from DataTypes.Enums.LobbyTypeEnum import LobbyTypeEnum

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'


class LobbyOptions:
    def __init__(self, obj):
        self.option_type = LobbyTypeEnum.parse(obj['OptionType'])

    def __str__(self):
        return LobbyTypeEnum.to_string(self.option_type)

class LobbyOptionsQuickMode(LobbyOptions):
    def __init__(self, obj):
        super().__init__(obj)
        self.starting_amount = obj['StartingAmount']
        self.minimum_amount_for_buy_in = self.starting_amount
        self.maximum_amount_for_buy_in = self.starting_amount

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


class LobbyOptionsDecoder():
    def decode(obj):
        type = LobbyTypeEnum.parse(obj['OptionType'])
        if type == LobbyTypeEnum.QuickMode:
            return LobbyOptionsQuickMode(obj)
        if type == LobbyTypeEnum.RegisteredMode:
            return LobbyOptionsRegisteredMode(obj)
        return None
