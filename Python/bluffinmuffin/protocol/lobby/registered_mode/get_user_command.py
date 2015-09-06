from bluffinmuffin.protocol.interfaces import AbstractLobbyCommand


class GetUserCommand(AbstractLobbyCommand):

    def __init__(self):
        super().__init__()

    @classmethod
    def decode(cls, obj):
        return cls()
