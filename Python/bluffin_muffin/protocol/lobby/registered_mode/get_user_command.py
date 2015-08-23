from protocol import AbstractLobbyCommand

__author__ = 'ericmas001@gmail.com'



class GetUserCommand(AbstractLobbyCommand):
    def __init__(self, obj):
        super().__init__(obj)