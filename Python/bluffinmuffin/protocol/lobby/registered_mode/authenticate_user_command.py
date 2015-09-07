from bluffinmuffin.protocol.interfaces import AbstractLobbyCommand


class AuthenticateUserCommand(AbstractLobbyCommand):
    def __init__(self, username, password):
        super().__init__()
        self.username = username
        self.password = password

    def __str__(self):
        return '{0} ({1} : {2})'.format(
            super().__str__(),
            self.username,
            self.password
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Username'] = self.username
        d['Password'] = self.password

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Username'],
            obj['Password']
        )
