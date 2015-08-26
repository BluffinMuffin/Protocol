from enum import Enum


class LimitTypeEnum(Enum):
    NoLimit = 0
    FixedLimit = 1
    PotLimit = 2

    @classmethod
    def parse(cls, str):
        return cls[str]

    @classmethod
    def to_string(cls, value):
        return value.name
