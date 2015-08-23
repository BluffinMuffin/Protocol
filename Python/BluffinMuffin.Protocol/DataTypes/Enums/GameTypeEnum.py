from enum import Enum

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

class GameTypeEnum(Enum):
    Holdem = 0

    def parse(str):
        return GameTypeEnum[str]

    def to_string(value):
        return value.name