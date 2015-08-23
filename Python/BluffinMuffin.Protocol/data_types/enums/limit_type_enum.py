from enum import Enum

__author__ = 'ericmas001@gmail.com'


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