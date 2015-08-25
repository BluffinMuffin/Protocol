from enum import Enum


class GameTypeEnum(Enum):
    Holdem = 0

    @classmethod
    def parse(cls, str):
        return cls[str]

    @classmethod
    def to_string(cls, value):
        return value.name
