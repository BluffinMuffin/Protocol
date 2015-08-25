from enum import Enum


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
