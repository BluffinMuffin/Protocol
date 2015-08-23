from AbstractCommand import AbstractCommand
from DataTypes.TableParams import TableParams

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'


class CreateTableCommand(AbstractCommand):
    def __init__(self, obj):
        super().__init__('CreateTableCommand', obj)
        self.params = TableParams(obj['Params'])

    def __str__( self ):
        return '{0} ({1})'.format(super().__str__(), self.params)
