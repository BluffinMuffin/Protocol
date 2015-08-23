from Python.bluffin_muffin.protocol2.abstract_game_command import AbstractGameCommand

__author__ = 'ericmas001@gmail.com'



class TableClosedCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)