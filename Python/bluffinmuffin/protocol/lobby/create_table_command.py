from bluffinmuffin.protocol.interfaces import AbstractLobbyCommand
from bluffinmuffin.protocol.data_types import TableParams


class CreateTableCommand(AbstractLobbyCommand):
    def __init__(self, params):
        super().__init__()
        self.params = params

    def __str__(self):
        return '{0} ({1})'.format(
            super().__str__(),
            self.params
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Params'] = self.params.encode()

    @classmethod
    def decode(cls, obj):
        return cls(
            TableParams.decode(obj['Params'])
        )
