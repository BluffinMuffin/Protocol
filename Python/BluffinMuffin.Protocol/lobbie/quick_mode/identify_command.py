from abstract_command import AbstractCommand

__author__ = 'ericmas001@gmail.com'



class IdentifyCommand(AbstractCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.name = obj['Name']

    def __str__( self ):
        return '{0} ({1})'.format(super().__str__(), self.name)
