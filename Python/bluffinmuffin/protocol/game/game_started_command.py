from bluffinmuffin.protocol.interfaces import AbstractGameCommand
from bluffinmuffin.protocol.data_types import SeatInfo


class GameStartedCommand(AbstractGameCommand):
    def __init__(self, table_id, needed_blind_amount, seats):
        super().__init__(table_id)
        self.needed_blind_amount = needed_blind_amount
        self.seats = seats

    def __str__(self):
        return '{0} ({1} [{2}])'.format(
            super().__str__(),
            self.needed_blind_amount,
            ', '.join([x.__str__() for x in self.seats])
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['NeededBlindAmount'] = self.needed_blind_amount
        d['Seats'] = [x.encode() for x in self.seats]

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj['NeededBlindAmount'],
            [SeatInfo.decode(x) for x in obj['Seats']]
        )
