from bluffinmuffin.protocol.interfaces import AbstractGameCommand


class PlayerSitInCommand(AbstractGameCommand):

    def __init__(self, table_id, no_seat, money_amount):
        super().__init__(table_id)
        self.no_seat = no_seat
        self.money_amount = money_amount

    def __str__(self):
        return '{0} ({1} {2})'.format(
            super().__str__(),
            self.no_seat,
            self.money_amount
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['NoSeat'] = self.no_seat
        d['MoneyAmount'] = self.money_amount

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj["NoSeat"],
            obj['MoneyAmount']
        )
