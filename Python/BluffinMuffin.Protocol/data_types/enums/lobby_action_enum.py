from enum import Enum

__author__ = 'ericmas001@gmail.com'


class LobbyActionEnum(Enum):
    Nothing = 0
    Join = 1
    Leave = 2

    @classmethod
    def parse(cls, str):
        if str == 'None':
            return LobbyActionEnum.Nothing
        return LobbyActionEnum[str]

    @classmethod
    def to_string(cls, value):
        if value == LobbyActionEnum.Nothing:
            return 'None'
        return value.name
