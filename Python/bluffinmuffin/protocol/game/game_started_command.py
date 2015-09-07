from bluffinmuffin.protocol.interfaces import AbstractGameCommand


class GameStartedCommand(AbstractGameCommand):

    def __init__(self, table_id, needed_blind_amount):
        super().__init__(table_id)
        self.needed_blind_amount = needed_blind_amount

    def __str__(self):
        return '{0} ({1})'.format(
            super().__str__(),
            self.needed_blind_amount
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['NeededBlindAmount'] = self.needed_blind_amount

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj['NeededBlindAmount']
        )
