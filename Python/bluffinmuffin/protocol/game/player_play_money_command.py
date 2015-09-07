from bluffinmuffin.protocol.interfaces import AbstractGameCommand


class PlayerPlayMoneyCommand(AbstractGameCommand):

    def __init__(self, table_id, amount_played):
        super().__init__(table_id)
        self.amount_played = amount_played

    def __str__(self):
        return '{0} ({1})'.format(
            super().__str__(),
            self.amount_played
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['AmountPlayed'] = self.amount_played

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj['AmountPlayed']
        )
