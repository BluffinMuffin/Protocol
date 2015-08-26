from bluffinmuffin.protocol.interfaces import AbstractGameCommand
from bluffinmuffin.protocol.data_types import SeatInfo


class SeatUpdatedCommand(AbstractGameCommand):

    def __init__(self, obj):
        super().__init__(obj)
        self.seat = SeatInfo(obj['Seat'])

    def __str__(self):
        return '{0} ({1})'.format(
            super().__str__(),
            self.seat
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Seat'] = self.seat.encode()
