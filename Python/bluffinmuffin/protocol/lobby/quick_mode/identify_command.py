from bluffinmuffin.protocol.interfaces import AbstractLobbyCommand


class IdentifyCommand(AbstractLobbyCommand):
    def __init__(self, name):
        super().__init__()
        self.name = name

    def __str__(self):
        return '{0} ({1})'.format(
            super().__str__(),
            self.name
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Name'] = self.name

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Name']
        )
