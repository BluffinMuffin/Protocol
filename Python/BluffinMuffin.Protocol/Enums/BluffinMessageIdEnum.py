from enum import Enum

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

class BluffinMessageIdEnum(Enum):
    Nothing = 0
    SpecificServerMessage = 1
    WrongTableState = 2
    NameAlreadyUsed = 3
    UsernameAlreadyUsed = 4
    UsernameNotFound = 5
    InvalidPassword = 6
    SeatChanged = 7
    NotAuthenticated = 8
    WrongLobbyType = 9
    NotSupported = 10

    def parse(str):
        if str == 'None':
            return BluffinMessageIdEnum.Nothing
        return BluffinMessageIdEnum[str]

    def to_string(value):
        if value == BluffinMessageIdEnum.Nothing:
            return 'None'
        return value.name
