from collections import OrderedDict

from bluffinmuffin.protocol.enums import LimitTypeEnum


class LimitOptions:

    def __init__(self, option_type):
        self.option_type = option_type

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

    def __init__(self):
        super().__init__(LimitTypeEnum.FixedLimit)

    @classmethod
    def decode(cls, obj):
        return cls()


class LimitOptionsNoLimit(LimitOptions):

    def __init__(self):
        super().__init__(LimitTypeEnum.NoLimit)

    @classmethod
    def decode(cls, obj):
        return cls()


class LimitOptionsPot(LimitOptions):

    def __init__(self):
        super().__init__(LimitTypeEnum.PotLimit)

    @classmethod
    def decode(cls, obj):
        return cls()


class LimitOptionsDecoder():

    @classmethod
    def decode(cls, obj):
        type = LimitTypeEnum.parse(obj['OptionType'])
        if type == LimitTypeEnum.FixedLimit:
            return LimitOptionsFixed.decode(obj)
        if type == LimitTypeEnum.NoLimit:
            return LimitOptionsNoLimit.decode(obj)
        if type == LimitTypeEnum.PotLimit:
            return LimitOptionsPot.decode(obj)
        return None
