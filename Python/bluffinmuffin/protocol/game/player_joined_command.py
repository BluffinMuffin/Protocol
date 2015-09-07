from bluffinmuffin.protocol.interfaces import AbstractGameCommand


class PlayerJoinedCommand(AbstractGameCommand):

    def __init__(self, table_id, player_name):
        super().__init__(table_id)
        self.player_name = player_name

    def __str__(self):
        return '{0} ({1})'.format(
            super().__str__(),
            self.player_name
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['PlayerName'] = self.player_name

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj['PlayerName']
        )
