from enum import Enum

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

class GameActionEnum(Enum):
    Fold = 0
    Call = 1
    Raise = 2
    PostSmallBlind = 3
    PostBigBlind = 4
    PostAnte = 5
    DoNothing = 6

    def parse(str):
        return GameActionEnum[str]

    def to_string(value):
        return value.name