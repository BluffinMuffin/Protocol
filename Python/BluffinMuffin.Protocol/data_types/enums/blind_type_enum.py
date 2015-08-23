from enum import Enum

__author__ = 'ericmas001@gmail.com'


class BlindTypeEnum(Enum):
    Blinds = 0
    Antes = 1
    Nothing = 2

    @classmethod
    def parse(cls, str):
        if str == 'None':
            return BlindTypeEnum.Nothing
        return BlindTypeEnum[str]

    @classmethod
    def to_string(cls, value):
        if value == BlindTypeEnum.Nothing:
            return 'None'
        return value.name
