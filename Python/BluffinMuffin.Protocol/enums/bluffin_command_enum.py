from enum import Enum

__author__ = 'ericmas001@gmail.com'


class BluffinCommandEnum(Enum):
    General = 0
    Lobby = 1
    Game = 2

    @classmethod
    def parse(cls, str):
        return BluffinCommandEnum[str]

    @classmethod
    def to_string(cls, value):
        return value.name
