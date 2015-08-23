from DataTypes.Enums.LimitTypeEnum import LimitTypeEnum

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'


class LimitOptions:
    def __init__(self, obj):
        self.option_type = LimitTypeEnum.parse(obj['OptionType'])

    def __str__(self):
        return LimitTypeEnum.to_string(self.option_type)

class LimitOptionsFixed(LimitOptions):
    def __init__(self, obj):
        super().__init__(obj)

class LimitOptionsNoLimit(LimitOptions):
    def __init__(self, obj):
        super().__init__(obj)

class LimitOptionsPot(LimitOptions):
    def __init__(self, obj):
        super().__init__(obj)

class LimitOptionsDecoder():
    def decode(obj):
        type = LimitTypeEnum.parse(obj['OptionType'])
        if type == LimitTypeEnum.FixedLimit:
            return LimitOptionsFixed(obj)
        if type == LimitTypeEnum.NoLimit:
            return LimitOptionsNoLimit(obj)
        if type == LimitTypeEnum.PotLimit:
            return LimitOptionsPot(obj)
        return None
