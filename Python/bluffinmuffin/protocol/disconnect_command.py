from bluffinmuffin.protocol.interfaces import AbstractCommand
from bluffinmuffin.protocol.enums import BluffinCommandEnum


class DisconnectCommand(AbstractCommand):

    def __init__(self, obj):
        super().__init__(obj, BluffinCommandEnum.General)
