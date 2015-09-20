from enum import Enum


class SeatAttributeEnum(Enum):
    Dealer = 0
    SmallBlind = 1
    BigBlind = 2
    CurrentPlayer = 3
    FirstTalker = 4

    @classmethod
    def parse(cls, str):
        return cls[str]

    @classmethod
    def to_string(cls, value):
        return value.name
