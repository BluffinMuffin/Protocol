from abstract_game_command import AbstractGameCommand
from data_types.seat_info import SeatInfo

__author__ = 'ericmas001@gmail.com'



class SeatUpdatedCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.seat = SeatInfo(obj['Seat'])

    def __str__( self ):
        return '{0} ({1})'.format(
            super().__str__(),
            self.seat
        )
