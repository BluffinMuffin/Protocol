from enums.bluffin_command_enum import BluffinCommandEnum

__author__ = 'ericmas001@gmail.com'


class AbstractCommand:

    def __init__(self, obj, command_type):
        self.command_name = self.__class__.__name__
        self.command_type = command_type

    def __str__( self ):
        return '[{0}] {1}'.format(BluffinCommandEnum.to_char(self.command_type), self.command_name)