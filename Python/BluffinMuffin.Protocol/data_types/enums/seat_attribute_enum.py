from enum import Enum

__author__ = 'ericmas001@gmail.com'


class SeatAttributeEnum(Enum):
    Dealer = 0
    SmallBlind = 1
    BigBlind = 2
    CurrentPlayer = 3

    @classmethod
    def parse(cls, str):
        return cls[str]

    @classmethod
    def to_string(cls, value):
        return value.name
