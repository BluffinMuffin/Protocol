from bluffinmuffin.protocol.enums import BluffinMessageIdEnum
from bluffinmuffin.protocol.interfaces import AbstractResponse
from .identify_command import IdentifyCommand


class IdentifyResponse(AbstractResponse):

    def __init__(self, success, message_id, message, jsonCommand):
        super().__init__(success, message_id, message, IdentifyCommand.decode(jsonCommand))

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Success'],
            BluffinMessageIdEnum.parse(obj['MessageId']),
            obj['Message'],
            obj['Command']
        )
