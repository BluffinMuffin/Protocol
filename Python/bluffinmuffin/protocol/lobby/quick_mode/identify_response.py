from bluffinmuffin.protocol.interfaces import AbstractResponse
from .identify_command import IdentifyCommand


class IdentifyResponse(AbstractResponse):

    def __init__(self, obj):
        super().__init__(obj, IdentifyCommand(obj['Command']))
