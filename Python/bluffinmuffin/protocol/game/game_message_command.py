from bluffinmuffin.protocol.interfaces import AbstractGameCommand
from bluffinmuffin.protocol.data_types import GameMessageOptionsDecoder


class GameMessageCommand(AbstractGameCommand):
    def __init__(self, table_id, message, info):
        super().__init__(table_id)
        self.message = message
        self.info = info

    def __str__(self):
        return '{0} {1} ({2})'.format(
            super().__str__(),
            self.message,
            self.info
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Message'] = self.message
        d['Info'] = self.info.encode()

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj["Message"],
            GameMessageOptionsDecoder.decode(obj['Info'])
        )
