from enum import Enum

__author__ = 'ericmas001@gmail.com'


class GameTypeEnum(Enum):
    Holdem = 0

    @classmethod
    def parse(cls, str):
        return cls[str]

    @classmethod
    def to_string(cls, value):
        return value.name