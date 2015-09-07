from bluffinmuffin.protocol.enums import BluffinMessageIdEnum
from bluffinmuffin.protocol.interfaces import AbstractGameResponse
from .player_sit_out_command import PlayerSitOutCommand


class PlayerSitOutResponse(AbstractGameResponse):
    def __init__(self, table_id, success, message_id, message, jsonCommand):
        super().__init__(table_id, success, message_id, message, PlayerSitOutCommand.decode(jsonCommand))

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj['Success'],
            BluffinMessageIdEnum.parse(obj['MessageId']),
            obj['Message'],
            obj['Command'],
        )
