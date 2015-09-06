from bluffinmuffin.protocol.enums import BluffinMessageIdEnum
from bluffinmuffin.protocol.interfaces import AbstractResponse
from .check_display_exist_command import CheckDisplayExistCommand


class CheckDisplayExistResponse(AbstractResponse):

    def __init__(self, success, message_id, message, jsonCommand, exist):
        super().__init__(success, message_id, message, CheckDisplayExistCommand.decode(jsonCommand))
        self.exist = exist

    def __str__(self):
        return '{0} => {1}'.format(
            super().__str__(),
            self.exist
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Exist'] = self.exist

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Success'],
            BluffinMessageIdEnum.parse(obj['MessageId']),
            obj['Message'],obj['Command'],
            obj['Exist']
        )
