from abstract_game_command import AbstractGameResponse
from game.player_sit_out_command import PlayerSitOutCommand

__author__ = 'ericmas001@gmail.com'



class PlayerSitOutResponse(AbstractGameResponse):
    def __init__(self, obj):
        super().__init__(obj, PlayerSitOutCommand(obj['Command']))