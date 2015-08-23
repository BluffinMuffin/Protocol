from abstract_lobby_command import AbstractLobbyCommand
from data_types.table_params import TableParams

__author__ = 'ericmas001@gmail.com'



class JoinTableCommand(AbstractLobbyCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.table_id = obj['TableId']

    def __str__( self ):
        return '{0} ({1})'.format(super().__str__(), self.table_id)
