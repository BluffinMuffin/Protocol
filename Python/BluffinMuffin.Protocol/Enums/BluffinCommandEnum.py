from enum import Enum

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

class BluffinCommandEnum(Enum):
    General = 0
    Lobby = 1
    Game = 2

    def parse(str):
        return BluffinCommandEnum[str]

    def to_string(value):
        return value.name
