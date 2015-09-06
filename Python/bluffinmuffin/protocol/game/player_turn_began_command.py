from bluffinmuffin.protocol.interfaces import AbstractGameCommand


class PlayerTurnBeganCommand(AbstractGameCommand):

    def __init__(self, obj):
        super().__init__(obj)
        self.no_seat = obj['NoSeat']
        self.amount_needed = obj['AmountNeeded']
        self.minimum_raise_amount = obj['MinimumRaiseAmount']

    def __str__(self):
        return '{0} ({1} {2}/{3})'.format(
            super().__str__(),
            self.no_seat,
            self.amount_needed,
            self.minimum_raise_amount
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['NoSeat'] = self.no_seat
        d['AmountNeeded'] = self.amount_needed
        d['MinimumRaiseAmount'] = self.minimum_raise_amount
