from protocol import AbstractGameCommand

__author__ = 'ericmas001@gmail.com'



class TableClosedCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)