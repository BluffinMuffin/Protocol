from enum import Enum

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

class SeatAttributeEnum(Enum):
    Dealer = 0
    SmallBlind = 1
    BigBlind = 2
    CurrentPlayer = 3

    def parse(str):
        return SeatAttributeEnum[str]

    def to_string(value):
        return value.name
