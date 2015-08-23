from collections import OrderedDict
from data_types.enums.blind_type_enum import BlindTypeEnum

__author__ = 'ericmas001@gmail.com'



class BlindOptions:
    def __init__(self, obj):
        self.money_unit = obj['MoneyUnit']
        self.option_type = BlindTypeEnum.parse(obj['OptionType'])

    def __str__(self):
        return BlindTypeEnum.to_string(self.option_type)

    def _encode_specific(self, d):
        return None

    def _encode_specific_end(self, d):
        return None

    def encode(self):
        d = OrderedDict()
        d['OptionType'] = BlindTypeEnum.to_string(self.option_type)
        d['MoneyUnit'] = self.money_unit
        self._encode_specific(d)
        self._encode_specific_end(d)
        return d

class BlindOptionsAnte(BlindOptions):
    def __init__(self, obj):
        super().__init__(obj)
        self.ante_amount = self.money_unit

    def __str__(self):
        return '{0} ({1})'.format(super().__str__(), self.ante_amount)

class BlindOptionsBlinds(BlindOptions):
    def __init__(self, obj):
        super().__init__(obj)
        self.big_blind_amount = self.money_unit
        self.small_blind_amount = self.money_unit // 2

    def __str__(self):
        return '{0} ({1}/{2})'.format(super().__str__(), self.small_blind_amount, self.big_blind_amount)

class BlindOptionsNone(BlindOptions):
    def __init__(self, obj):
        super().__init__(obj)

class BlindOptionsDecoder():
    @classmethod
    def decode(cls, obj):
        type = BlindTypeEnum.parse(obj['OptionType'])
        if type == BlindTypeEnum.Antes:
            return BlindOptionsAnte(obj)
        if type == BlindTypeEnum.Blinds:
            return BlindOptionsBlinds(obj)
        if type == BlindTypeEnum.Nothing:
            return BlindOptionsNone(obj)
        return None
