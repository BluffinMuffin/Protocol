from enum import Enum

__author__ = 'ericmas001@gmail.com'


class RoundTypeEnum(Enum):
    Preflop = 0
    Flop = 1
    Turn = 2
    River = 3

    @classmethod
    def parse(cls, str):
        return RoundTypeEnum[str]

    @classmethod
    def to_string(cls, value):
        return value.name
