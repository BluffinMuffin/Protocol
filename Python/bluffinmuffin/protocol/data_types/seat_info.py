from collections import OrderedDict

from bluffinmuffin.protocol.enums import SeatAttributeEnum
from .player_info import PlayerInfo


class SeatInfo:

    def __init__(self, no_seat, player, seat_attributes):
        self.no_seat = no_seat
        self.player = player
        self.seat_attributes = seat_attributes

    def __str__(self):
        return '{0} ({1}) [{2}]'.format(
            self.no_seat,
            self.player,
            ', '.join([SeatAttributeEnum.to_string(x) for x in self.seat_attributes])
        )

    def encode(self):
        d = OrderedDict()
        d['NoSeat'] = self.no_seat
        d['Player'] = self.player.encode()
        d['SeatAttributes'] = [SeatAttributeEnum.to_string(x) for x in self.seat_attributes]
        return d

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["NoSeat"],
            PlayerInfo.decode(obj['Player']),
            [SeatAttributeEnum.parse(x) for x in obj['SeatAttributes']]
        )
