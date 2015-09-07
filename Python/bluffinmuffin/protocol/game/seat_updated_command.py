from bluffinmuffin.protocol.interfaces import AbstractGameCommand
from bluffinmuffin.protocol.data_types import SeatInfo


class SeatUpdatedCommand(AbstractGameCommand):
    def __init__(self, table_id, seat):
        super().__init__(table_id)
        self.seat = seat

    def __str__(self):
        return '{0} ({1})'.format(
            super().__str__(),
            self.seat
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Seat'] = self.seat.encode()

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            SeatInfo.decode(obj['Seat'])
        )
