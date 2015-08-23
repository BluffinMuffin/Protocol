from enum import Enum

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

class RoundTypeEnum(Enum):
    Preflop = 0
    Flop = 1
    Turn = 2
    River = 3

    def parse(str):
        return RoundTypeEnum[str]

    def to_string(value):
        return value.name
