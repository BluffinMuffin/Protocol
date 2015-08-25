from enum import Enum


class BlindTypeEnum(Enum):
    Blinds = 0
    Antes = 1
    Nothing = 2

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
