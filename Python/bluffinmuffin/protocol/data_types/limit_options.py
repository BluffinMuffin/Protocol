from collections import OrderedDict

from .enums.limit_type_enum import LimitTypeEnum


class LimitOptions:

    def __init__(self, obj):
        self.option_type = LimitTypeEnum.parse(obj['OptionType'])

    def __str__(self):
        return LimitTypeEnum.to_string(self.option_type)

    def _encode_specific(self, d):
        return None

    def _encode_specific_end(self, d):
        return None

    def encode(self):
        d = OrderedDict()
        d['OptionType'] = LimitTypeEnum.to_string(self.option_type)
        self._encode_specific(d)
        self._encode_specific_end(d)
        return d


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
