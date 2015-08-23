from enum import Enum

__author__ = 'ericmas001@gmail.com'


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

    @classmethod
    def parse(cls, str):
        if str == 'None':
            return PokerHandEnum.Nothing
        return PokerHandEnum[str]

    @classmethod
    def to_string(cls, value):
        if value == PokerHandEnum.Nothing:
            return 'None'
        return value.name
