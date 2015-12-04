from enum import Enum


class PlayerStateEnum(Enum):
    Nothing = 0
    Joined = 1
    SitIn = 2
    AllIn = 3
    Playing = 4

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
