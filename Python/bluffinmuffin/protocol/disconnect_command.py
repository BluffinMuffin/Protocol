from bluffinmuffin.protocol.interfaces import AbstractCommand
from bluffinmuffin.protocol.enums import BluffinCommandEnum


class DisconnectCommand(AbstractCommand):

    def __init__(self):
        super().__init__(BluffinCommandEnum.General)

    @classmethod
    def decode(cls, obj):
        return cls()
