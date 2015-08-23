from abstract_response import AbstractResponse
from data_types.enums.lobby_type_enum import LobbyTypeEnum
from data_types.rule_info import RuleInfo
from lobby.check_compatibility_command import CheckCompatibilityCommand
from lobby.create_table_command import CreateTableCommand

__author__ = 'ericmas001@gmail.com'



class CheckCompatibilityResponse(AbstractResponse):
    def __init__(self, obj):
        super().__init__(obj, CheckCompatibilityCommand(obj['Command']))
        self.implemented_protocol_version = obj['ImplementedProtocolVersion']
        self.supported_lobby_types = [LobbyTypeEnum.parse(x) for x in obj['SupportedLobbyTypes']]
        self.rules = [RuleInfo(x) for x in obj['Rules']]

    def __str__( self ):
        return '{0} => {1} ({2}) ({3})'.format(super().__str__(), self.implemented_protocol_version, ', '.join([LobbyTypeEnum.to_string(x) for x in self.supported_lobby_types]), ', '.join([x.__str__() for x in self.rules]))