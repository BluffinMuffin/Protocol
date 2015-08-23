from Python.bluffin_muffin.protocol.abstract_game_command import AbstractGameCommand

__author__ = 'ericmas001@gmail.com'



class PlayerTurnBeganCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.no_seat = obj['NoSeat']
        self.minimum_raise_amount = obj['MinimumRaiseAmount']

    def __str__( self ):
        return '{0} ({1} {2})'.format(
            super().__str__(),
            self.no_seat,
            self.minimum_raise_amount
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['NoSeat'] = self.no_seat
        d['MinimumRaiseAmount'] = self.minimum_raise_amount