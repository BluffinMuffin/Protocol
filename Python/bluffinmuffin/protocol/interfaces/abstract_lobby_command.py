from .abstract_command import AbstractCommand
from ..enums.bluffin_command_enum import BluffinCommandEnum


class AbstractLobbyCommand(AbstractCommand):
    def __init__(self):
        super().__init__(BluffinCommandEnum.Lobby)
