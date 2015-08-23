from DataTypes.Enums.BlindTypeEnum import BlindTypeEnum

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'


class BlindOptions:
    def __init__(self, obj):
        self.money_unit = obj['MoneyUnit']
        self.option_type = BlindTypeEnum.parse(obj['OptionType'])

    def __str__(self):
        return BlindTypeEnum.to_string(self.option_type)

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
    def decode(obj):
        type = BlindTypeEnum.parse(obj['OptionType'])
        if type == BlindTypeEnum.Antes:
            return BlindOptionsAnte(obj)
        if type == BlindTypeEnum.Blinds:
            return BlindOptionsBlinds(obj)
        if type == BlindTypeEnum.Nothing:
            return BlindOptionsNone(obj)
        return None
