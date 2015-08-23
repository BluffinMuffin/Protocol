from Python.bluffin_muffin.protocol2.abstract_game_command import AbstractGameCommand

__author__ = 'ericmas001@gmail.com'



class PlayerSitInCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.no_seat = obj['NoSeat']
        self.money_amount = obj['MoneyAmount']

    def __str__( self ):
        return '{0} ({1} {2})'.format(
            super().__str__(),
            self.no_seat,
            self.money_amount
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['NoSeat'] = self.no_seat
        d['MoneyAmount'] = self.money_amount