from enum import Enum


class GameMessageEnum(Enum):
    GeneralInformation = 0
    RaisingCapped = 1
    StudBringIn = 2
    StudHighestHand = 3
    PlayerJoined = 4
    PlayerLeft = 5

    @classmethod
    def parse(cls, str):
        return cls[str]

    @classmethod
    def to_string(cls, value):
        return value.name
