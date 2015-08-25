from enum import Enum


class LobbyActionEnum(Enum):
    Nothing = 0
    Join = 1
    Leave = 2

    @classmethod
    def parse(cls, str):
        if str == 'None':
            return cls.Nothing
        return cls[str]

    @classmethod
    def to_string(cls, value):
        if value == cls.Nothing:
            return 'None'
        return value.name
