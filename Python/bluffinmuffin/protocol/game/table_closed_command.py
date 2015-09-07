from bluffinmuffin.protocol.interfaces import AbstractGameCommand


class TableClosedCommand(AbstractGameCommand):
    def __init__(self, table_id):
        super().__init__(table_id)

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"]
        )
