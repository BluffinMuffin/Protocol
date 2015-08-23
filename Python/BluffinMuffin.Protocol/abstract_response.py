import json
from abstract_command import AbstractCommand
from enums.bluffin_message_id_enum import BluffinMessageIdEnum

__author__ = 'ericmas001@gmail.com'


class AbstractResponse(AbstractCommand):

    def __init__(self, obj, command):
        super().__init__(obj, command.command_type)
        self.success = obj['Success']
        self.message_id = BluffinMessageIdEnum.parse(obj['MessageId'])
        self.message = obj['Message']
        self.command = command

    def __str__( self ):
        return '{0} ({1}: {2} - {3} [{4}])'.format(super().__str__(), self.success, BluffinMessageIdEnum.to_string(self.message_id), self.message, self.command)