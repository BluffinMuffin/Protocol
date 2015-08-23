from data_types.enums.limit_type_enum import LimitTypeEnum

__author__ = 'ericmas001@gmail.com'



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
    @classmethod
    def decode(cls, obj):
        type = LimitTypeEnum.parse(obj['OptionType'])
        if type == LimitTypeEnum.FixedLimit:
            return LimitOptionsFixed(obj)
        if type == LimitTypeEnum.NoLimit:
            return LimitOptionsNoLimit(obj)
        if type == LimitTypeEnum.PotLimit:
            return LimitOptionsPot(obj)
        return None
