from bluffinmuffin.protocol.interfaces import AbstractLobbyCommand


class CreateUserCommand(AbstractLobbyCommand):
    def __init__(self, username, password, email, display_name):
        super().__init__()
        self.username = username
        self.password = password
        self.email = email
        self.display_name = display_name

    def __str__(self):
        return '{0} ({1} : {2}, {3}, {4})'.format(
            super().__str__(),
            self.username,
            self.password,
            self.email,
            self.display_name
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Username'] = self.username
        d['Password'] = self.password
        d['Email'] = self.email
        d['DisplayName'] = self.display_name

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Username'],
            obj['Password'],
            obj['Email'],
            obj['DisplayName']
        )
