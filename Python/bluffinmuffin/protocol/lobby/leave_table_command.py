from bluffinmuffin.protocol.interfaces import AbstractLobbyCommand


class LeaveTableCommand(AbstractLobbyCommand):

    def __init__(self, table_id):
        super().__init__()
        self.table_id = table_id

    def __str__(self):
        return '{0} ({1})'.format(
            super().__str__(),
            self.table_id
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['TableId'] = self.table_id

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['TableId']
        )
