from protocol import AbstractCommand
from bluffin_command_enum import BluffinCommandEnum

__author__ = 'ericmas001@gmail.com'


class AbstractLobbyCommand(AbstractCommand):

    def __init__(self, obj):
        super().__init__(obj, BluffinCommandEnum.Lobby)