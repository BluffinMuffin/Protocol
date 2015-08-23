from enum import Enum

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

class LobbyTypeEnum(Enum):
    QuickMode = 0
    RegisteredMode = 1

    def parse(str):
        return LobbyTypeEnum[str]

    def to_string(value):
        return value.name