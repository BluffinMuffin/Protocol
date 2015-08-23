from DisconnectCommand import DisconnectCommand
from Lobby.QuickMode.IdentifyCommand import IdentifyCommand
from Lobby.QuickMode.IdentifyResponse import IdentifyResponse

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

class CommandDecoder:

    def decode(obj):
        if 'CommandName' in obj and obj['CommandName'] == 'DisconnectCommand':
            return DisconnectCommand(obj)
        if 'CommandName' in obj and obj['CommandName'] == 'IdentifyCommand':
            return IdentifyCommand(obj)
        if 'CommandName' in obj and obj['CommandName'] == 'IdentifyResponse':
            return IdentifyResponse(obj, CommandDecoder.decode(obj['Command']))
        return None