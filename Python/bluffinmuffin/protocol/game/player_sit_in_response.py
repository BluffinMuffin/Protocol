from bluffinmuffin.protocol.enums import BluffinMessageIdEnum
from bluffinmuffin.protocol.interfaces import AbstractGameResponse
from .player_sit_in_command import PlayerSitInCommand


class PlayerSitInResponse(AbstractGameResponse):
    def __init__(self, table_id, success, message_id, message, jsonCommand, no_seat):
        super().__init__(table_id, success, message_id, message, PlayerSitInCommand.decode(jsonCommand))
        self.no_seat = no_seat

    def __str__(self):
        return '{0} => {1}'.format(
            super().__str__(),
            self.no_seat
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['NoSeat'] = self.no_seat

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj['Success'],
            BluffinMessageIdEnum.parse(obj['MessageId']),
            obj['Message'],
            obj['Command'],
            obj['NoSeat']
        )
