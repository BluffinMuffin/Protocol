__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

class AbstractCommand:

    def __init__(self, name, obj):
        self.command_name = name

    def __str__( self ):
        return self.command_name