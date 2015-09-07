import json

from .abstract_command import AbstractCommand
from ..enums.bluffin_message_id_enum import BluffinMessageIdEnum


class AbstractResponse(AbstractCommand):
    def __init__(self, success, message_id, message, command):
        super().__init__(command.command_type)
        self.success = success
        self.message_id = message_id
        self.message = message
        self.command = command

    def __str__(self):
        return '{0} ({1}: {2} - {3} [{4}])'.format(
            super().__str__(),
            self.success,
            BluffinMessageIdEnum.to_string(self.message_id),
            self.message,
            self.command)

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Success'] = self.success
        d['MessageId'] = BluffinMessageIdEnum.to_string(self.message_id)
        d['Message'] = self.message

    def _encode_specific_end(self, d):
        super()._encode_specific(d)
        d['Command'] = json.loads(self.command.encode())
