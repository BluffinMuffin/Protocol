from collections import OrderedDict

from .enums.seat_attribute_enum import SeatAttributeEnum
from .player_info import PlayerInfo


class SeatInfo:

    def __init__(self, obj):
        self.no_seat = obj['NoSeat']
        self.player = PlayerInfo(obj['Player'])
        self.seat_attributes = [SeatAttributeEnum.parse(x) for x in obj['SeatAttributes']]

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
