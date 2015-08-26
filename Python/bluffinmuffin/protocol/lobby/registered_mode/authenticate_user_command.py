from protocol import AbstractLobbyCommand


class AuthenticateUserCommand(AbstractLobbyCommand):

    def __init__(self, obj):
        super().__init__(obj)
        self.username = obj['Username']
        self.password = obj['Password']

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
