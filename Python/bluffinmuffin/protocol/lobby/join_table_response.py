from bluffinmuffin.protocol.enums import BluffinMessageIdEnum
from bluffinmuffin.protocol.interfaces import AbstractResponse
from .join_table_command import JoinTableCommand


class JoinTableResponse(AbstractResponse):

    def __init__(self, success, message_id, message, jsonCommand):
        super().__init__(success, message_id, message, JoinTableCommand.decode(jsonCommand))

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Success'],
            BluffinMessageIdEnum.parse(obj['MessageId']),
            obj['Message'],
            obj['Command']
        )