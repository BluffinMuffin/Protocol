from abstract_command import AbstractCommand

__author__ = 'ericmas001@gmail.com'



class DisconnectCommand(AbstractCommand):
    def __init__(self, obj):
        super().__init__(obj)
