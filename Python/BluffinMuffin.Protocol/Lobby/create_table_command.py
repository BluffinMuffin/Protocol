from abstract_command import AbstractCommand
from data_types.table_params import TableParams

__author__ = 'ericmas001@gmail.com'



class CreateTableCommand(AbstractCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.params = TableParams(obj['Params'])

    def __str__( self ):
        return '{0} ({1})'.format(super().__str__(), self.params)
