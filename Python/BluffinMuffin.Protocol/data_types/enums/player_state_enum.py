from enum import Enum

__author__ = 'ericmas001@gmail.com'


class PlayerStateEnum(Enum):
    Zombie = 0
    Joined = 1
    SitIn = 2
    AllIn = 3
    Playing = 4

    @classmethod
    def parse(cls, str):
        return cls[str]

    @classmethod
    def to_string(cls, value):
        return value.name