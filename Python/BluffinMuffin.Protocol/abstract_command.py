__author__ = 'ericmas001@gmail.com'


class AbstractCommand:

    def __init__(self, obj):
        self.command_name = self.__class__.__name__

    def __str__( self ):
        return self.command_name