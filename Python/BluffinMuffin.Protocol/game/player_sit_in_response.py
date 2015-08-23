from abstract_game_command import AbstractGameResponse
from game.player_sit_in_command import PlayerSitInCommand

__author__ = 'ericmas001@gmail.com'



class PlayerSitInResponse(AbstractGameResponse):
    def __init__(self, obj):
        super().__init__(obj, PlayerSitInCommand(obj['Command']))
        self.no_seat = obj['NoSeat']

    def __str__( self ):
        return '{0} => {1}'.format(super().__str__(), self.no_seat)