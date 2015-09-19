from enum import Enum


class GameSubTypeEnum(Enum):
    TexasHoldem = 0
    OmahaHoldem = 1
    Pineapple = 2
    CrazyPineapple = 3
    LazyPineapple = 4
    ThreeCardsHoldem = 5
    IrishPoker = 6
    SpanishPoker = 7
    ManilaPoker = 8
    FiveCardsStud = 9
    SevenCardsStud = 10
    FiveCardsDraw = 11

    @classmethod
    def parse(cls, str):
        return cls[str]

    @classmethod
    def to_string(cls, value):
        return value.name
