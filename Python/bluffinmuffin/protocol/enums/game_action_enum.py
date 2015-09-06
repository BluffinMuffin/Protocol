from enum import Enum


class GameActionEnum(Enum):
    Fold = 0
    Call = 1
    Raise = 2
    PostSmallBlind = 3
    PostBigBlind = 4
    PostAnte = 5
    DoNothing = 6

    @classmethod
    def parse(cls, str):
        return cls[str]

    @classmethod
    def to_string(cls, value):
        return value.name
