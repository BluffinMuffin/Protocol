import json
from AbstractCommand import AbstractCommand
from Enums.BluffinMessageIdEnum import BluffinMessageIdEnum

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

class AbstractResponse(AbstractCommand):

    def __init__(self, name, obj, command):
        super().__init__(name, obj)
        self.success = obj['Success']
        self.message_id = BluffinMessageIdEnum.parse(obj['MessageId'])
        self.message = obj['Message']
        self.command = command

    def __str__( self ):
        return '{0} ({1}: {2} - {3} [{4}])'.format(super().__str__(), self.success, BluffinMessageIdEnum.to_string(self.message_id), self.message, self.command)