from AbstractCommand import AbstractCommand

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'


class IdentifyCommand(AbstractCommand):
    def __init__(self, obj):
        super().__init__('IdentifyCommand', obj)
        self.name = obj['Name']

    def __str__( self ):
        return '{0} ({1})'.format(super().__str__(), self.name)
