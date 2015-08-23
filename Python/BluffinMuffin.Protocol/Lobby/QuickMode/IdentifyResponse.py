from AbstractResponse import AbstractResponse
from Lobby.QuickMode.IdentifyCommand import IdentifyCommand

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'


class IdentifyResponse(AbstractResponse):
    def __init__(self, obj):
        super().__init__('IdentifyResponse', obj, IdentifyCommand(obj['Command']))