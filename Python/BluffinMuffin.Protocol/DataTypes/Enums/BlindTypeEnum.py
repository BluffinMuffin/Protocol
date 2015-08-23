from enum import Enum

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

class BlindTypeEnum(Enum):
    Blinds = 0
    Antes = 1
    Nothing = 2

    def parse(str):
        if str == 'None':
            return BlindTypeEnum.Nothing
        return BlindTypeEnum[str]

    def to_string(value):
        if value == BlindTypeEnum.Nothing:
            return 'None'
        return value.name
