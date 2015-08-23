from enum import Enum

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

class PokerHandEnum(Enum):
    Nothing = 0
    HighCard = 1
    OnePair = 2
    TwoPairs = 3
    ThreeOfAKind = 4
    Straight = 5
    Flush = 6
    FullHouse = 7
    FourOfAKind = 8
    StraightFlush = 9

    def parse(str):
        if str == 'None':
            return PokerHandEnum.Nothing
        return PokerHandEnum[str]

    def to_string(value):
        if value == PokerHandEnum.Nothing:
            return 'None'
        return value.name
