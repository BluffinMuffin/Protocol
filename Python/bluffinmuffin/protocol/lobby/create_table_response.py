from bluffinmuffin.protocol.interfaces import AbstractResponse
from .create_table_command import CreateTableCommand


class CreateTableResponse(AbstractResponse):

    def __init__(self, obj):
        super().__init__(obj, CreateTableCommand(obj['Command']))
        self.id_table = obj['IdTable']

    def __str__(self):
        return '{0} => {1}'.format(
            super().__str__(),
            self.id_table
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['IdTable'] = self.id_table
