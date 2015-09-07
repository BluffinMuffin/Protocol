from bluffinmuffin.protocol.interfaces import AbstractLobbyCommand
from bluffinmuffin.protocol.enums import LobbyTypeEnum


class ListTableCommand(AbstractLobbyCommand):
    def __init__(self, lobby_types):
        super().__init__()
        self.lobby_types = lobby_types

    def __str__(self):
        return '{0} ({1})'.format(
            super().__str__(),
            ', '.join([LobbyTypeEnum.to_string(x) for x in self.lobby_types])
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['LobbyTypes'] = [LobbyTypeEnum.to_string(x) for x in self.lobby_types]

    @classmethod
    def decode(cls, obj):
        return cls(
            [LobbyTypeEnum.parse(x) for x in obj['LobbyTypes']]
        )
