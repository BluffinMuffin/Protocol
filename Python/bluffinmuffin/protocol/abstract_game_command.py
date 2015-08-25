import json

from abstract_command import AbstractCommand
from abstract_response import AbstractResponse
from enums.bluffin_command_enum import BluffinCommandEnum
from bluffin_message_id_enum import BluffinMessageIdEnum


class AbstractGameCommand(AbstractCommand):

    def __init__(self, obj):
        super().__init__(obj, BluffinCommandEnum.Game)
        self.table_id = obj['TableId']

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

    def __init__(self, obj, command):
        super().__init__(obj, command)
        self.table_id = obj['TableId']

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
