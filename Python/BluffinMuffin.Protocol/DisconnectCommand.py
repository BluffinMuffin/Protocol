from AbstractCommand import AbstractCommand

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'


class DisconnectCommand(AbstractCommand):
    def __init__(self, obj):
        super().__init__('DisconnectCommand', obj)
