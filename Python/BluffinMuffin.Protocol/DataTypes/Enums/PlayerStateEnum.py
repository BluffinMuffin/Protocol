from enum import Enum

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

class PlayerStateEnum(Enum):
    Zombie = 0
    Joined = 1
    SitIn = 2
    AllIn = 3
    Playing = 4

    def parse(str):
        return PlayerStateEnum[str]

    def to_string(value):
        return value.name