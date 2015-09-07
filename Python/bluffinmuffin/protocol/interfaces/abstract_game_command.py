import json

from .abstract_command import AbstractCommand
from .abstract_response import AbstractResponse
from ..enums.bluffin_command_enum import BluffinCommandEnum
from ..enums.bluffin_message_id_enum import BluffinMessageIdEnum


class AbstractGameCommand(AbstractCommand):
    def __init__(self, table_id):
        super().__init__(BluffinCommandEnum.Game)
        self.table_id = table_id

    def __str__(self):
        return '[{0}:{1}] {2}'.format(
            BluffinCommandEnum.to_char(self.command_type),
            self.table_id,
            self.command_name
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['TableId'] = self.table_id


class AbstractGameResponse(AbstractResponse):
    def __init__(self, table_id, success, message_id, message, command):
        super().__init__(success, message_id, message, command)
        self.table_id = table_id

    def __str__(self):
        return '[{0}:{1}] {2} ({3}: {4} - {5} [{6}])'.format(
            BluffinCommandEnum.to_char(self.command_type),
            self.table_id,
            self.command_name,
            self.success,
            BluffinMessageIdEnum.to_string(self.message_id),
            self.message,
            self.command
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Success'] = self.success
        d['MessageId'] = BluffinMessageIdEnum.to_string(self.message_id)
        d['Message'] = self.message
        d['TableId'] = self.table_id

    def _encode_specific_end(self, d):
        super()._encode_specific(d)
        d['Command'] = json.loads(self.command.encode())
