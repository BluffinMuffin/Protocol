from bluffinmuffin.protocol.interfaces import AbstractGameCommand


class PlayerTurnBeganCommand(AbstractGameCommand):
    def __init__(self, table_id, no_seat, amount_needed, minimum_raise_amount):
        super().__init__(table_id)
        self.no_seat = no_seat
        self.amount_needed = amount_needed
        self.minimum_raise_amount = minimum_raise_amount

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

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj["NoSeat"],
            obj["AmountNeeded"],
            obj['MinimumRaiseAmount']
        )
