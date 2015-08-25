from enum import Enum


class BluffinCommandEnum(Enum):
    General = 0
    Lobby = 1
    Game = 2

    @classmethod
    def parse(cls, str):
        return cls[str]

    @classmethod
    def to_string(cls, value):
        return value.name

    @classmethod
    def to_char(cls, value):
        if value == cls.Game:
            return 'G'
        if value == cls.Lobby:
            return 'L'
        return 'X'
