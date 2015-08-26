from enum import Enum


class LobbyTypeEnum(Enum):
    QuickMode = 0
    RegisteredMode = 1

    @classmethod
    def parse(cls, str):
        return cls[str]

    @classmethod
    def to_string(cls, value):
        return value.name
