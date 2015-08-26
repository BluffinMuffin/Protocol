from protocol import AbstractLobbyCommand
from table_params import TableParams


class CreateTableCommand(AbstractLobbyCommand):

    def __init__(self, obj):
        super().__init__(obj)
        self.params = TableParams(obj['Params'])

    def __str__(self):
        return '{0} ({1})'.format(
            super().__str__(),
            self.params
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Params'] = self.params.encode()
