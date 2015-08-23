from protocol import AbstractLobbyCommand
from lobby_type_enum import LobbyTypeEnum

__author__ = 'ericmas001@gmail.com'



class ListTableCommand(AbstractLobbyCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.lobby_types = [LobbyTypeEnum.parse(x) for x in obj['LobbyTypes']]

    def __str__( self ):
        return '{0} ({1})'.format(
            super().__str__(),
            ', '.join([LobbyTypeEnum.to_string(x) for x in self.lobby_types])
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['LobbyTypes'] = [LobbyTypeEnum.to_string(x) for x in self.lobby_types]