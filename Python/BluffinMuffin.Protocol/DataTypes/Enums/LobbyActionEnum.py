from enum import Enum

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

class LobbyActionEnum(Enum):
    Nothing = 0
    Join = 1
    Leave = 2

    def parse(str):
        if str == 'None':
            return LobbyActionEnum.Nothing
        return LobbyActionEnum[str]

    def to_string(value):
        if value == LobbyActionEnum.Nothing:
            return 'None'
        return value.name
