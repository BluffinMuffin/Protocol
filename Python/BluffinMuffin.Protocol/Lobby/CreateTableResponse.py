from AbstractResponse import AbstractResponse
from Lobby.CreateTableCommand import CreateTableCommand

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'


class CreateTableResponse(AbstractResponse):
    def __init__(self, obj):
        super().__init__('CreateTableResponse', obj, CreateTableCommand(obj['Command']))
        self.id_table = obj['IdTable']

    def __str__( self ):
        return '{0} => {1}'.format(super().__str__(), self.id_table)