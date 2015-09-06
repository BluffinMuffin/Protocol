from enum import Enum


class RoundTypeEnum(Enum):
    Preflop = 0
    Flop = 1
    Turn = 2
    River = 3

    @classmethod
    def parse(cls, str):
        return cls[str]

    @classmethod
    def to_string(cls, value):
        return value.name
