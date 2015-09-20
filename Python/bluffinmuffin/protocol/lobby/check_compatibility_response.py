from bluffinmuffin.protocol.interfaces import AbstractResponse
from bluffinmuffin.protocol.enums import LobbyTypeEnum, BluffinMessageIdEnum
from bluffinmuffin.protocol.data_types import GameInfo
from .check_compatibility_command import CheckCompatibilityCommand


class CheckCompatibilityResponse(AbstractResponse):
    def __init__(self, success, message_id, message, jsonCommand, implemented_protocol_version, supported_lobby_types,
                 available_games):
        super().__init__(success, message_id, message, CheckCompatibilityCommand.decode(jsonCommand))
        self.implemented_protocol_version = implemented_protocol_version
        self.supported_lobby_types = supported_lobby_types
        self.available_games = available_games

    def __str__(self):
        return '{0} => {1} ({2}) ({3})'.format(
            super().__str__(),
            self.implemented_protocol_version,
            ', '.join([LobbyTypeEnum.to_string(x) for x in self.supported_lobby_types]),
            ', '.join([x.__str__() for x in self.available_games])
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['ImplementedProtocolVersion'] = self.implemented_protocol_version
        d['SupportedLobbyTypes'] = [LobbyTypeEnum.to_string(x) for x in self.supported_lobby_types]
        d['AvailableGames'] = [x.encode() for x in self.available_games]

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Success'],
            BluffinMessageIdEnum.parse(obj['MessageId']),
            obj['Message'],
            obj['Command'],
            obj['ImplementedProtocolVersion'],
            [LobbyTypeEnum.parse(x) for x in obj['SupportedLobbyTypes']],
            [GameInfo.decode(x) for x in obj['AvailableGames']]
        )
