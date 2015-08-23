from Python.bluffin_muffin.protocol2.abstract_response import AbstractResponse
from lobby_type_enum import LobbyTypeEnum
from rule_info import RuleInfo
from check_compatibility_command import CheckCompatibilityCommand

__author__ = 'ericmas001@gmail.com'



class CheckCompatibilityResponse(AbstractResponse):
    def __init__(self, obj):
        super().__init__(obj, CheckCompatibilityCommand(obj['Command']))
        self.implemented_protocol_version = obj['ImplementedProtocolVersion']
        self.supported_lobby_types = [LobbyTypeEnum.parse(x) for x in obj['SupportedLobbyTypes']]
        self.rules = [RuleInfo(x) for x in obj['Rules']]

    def __str__( self ):
        return '{0} => {1} ({2}) ({3})'.format(
            super().__str__(),
            self.implemented_protocol_version,
            ', '.join([LobbyTypeEnum.to_string(x) for x in self.supported_lobby_types]),
            ', '.join([x.__str__() for x in self.rules])
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['ImplementedProtocolVersion'] = self.implemented_protocol_version
        d['SupportedLobbyTypes'] = [LobbyTypeEnum.to_string(x) for x in self.supported_lobby_types]
        d['Rules'] = [x.encode() for x in self.rules]