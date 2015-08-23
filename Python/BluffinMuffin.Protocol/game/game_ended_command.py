from abstract_game_command import AbstractGameCommand

__author__ = 'ericmas001@gmail.com'



class GameEndedCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)
