from enum import Enum

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

class LimitTypeEnum(Enum):
    NoLimit = 0
    FixedLimit = 1
    PotLimit = 2

    def parse(str):
        return LimitTypeEnum[str]

    def to_string(value):
        return value.name