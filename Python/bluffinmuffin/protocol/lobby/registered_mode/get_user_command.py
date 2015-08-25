from protocol import AbstractLobbyCommand


class GetUserCommand(AbstractLobbyCommand):
    def __init__(self, obj):
        super().__init__(obj)
