from collections import OrderedDict
from bluffinmuffin.protocol.enums import BlindTypeEnum


class BlindOptions:
    def __init__(self, money_unit, option_type):
        self.money_unit = money_unit
        self.option_type = option_type

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
    def __init__(self, money_unit):
        super().__init__(money_unit, BlindTypeEnum.Antes)
        self.ante_amount = self.money_unit

    def __str__(self):
        return '{0} ({1})'.format(super().__str__(), self.ante_amount)

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['MoneyUnit']
        )


class BlindOptionsBlinds(BlindOptions):
    def __init__(self, money_unit):
        super().__init__(money_unit, BlindTypeEnum.Blinds)
        self.big_blind_amount = self.money_unit
        self.small_blind_amount = self.money_unit // 2

    def __str__(self):
        return '{0} ({1}/{2})'.format(super().__str__(), self.small_blind_amount, self.big_blind_amount)

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['MoneyUnit']
        )


class BlindOptionsNone(BlindOptions):
    def __init__(self, money_unit):
        super().__init__(money_unit, BlindTypeEnum.Nothing)

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['MoneyUnit']
        )


class BlindOptionsDecoder():
    @classmethod
    def decode(cls, obj):
        type = BlindTypeEnum.parse(obj['OptionType'])
        if type == BlindTypeEnum.Antes:
            return BlindOptionsAnte.decode(obj)
        if type == BlindTypeEnum.Blinds:
            return BlindOptionsBlinds.decode(obj)
        if type == BlindTypeEnum.Nothing:
            return BlindOptionsNone.decode(obj)
        return None
