from bluffinmuffin.protocol.interfaces import AbstractGameCommand


class BetTurnEndedCommand(AbstractGameCommand):
    def __init__(self, table_id, pots_amounts):
        super().__init__(table_id)
        self.pots_amounts = pots_amounts

    def __str__(self):
        return '{0} ({1} [{2}])'.format(
            super().__str__(),
            ', '.join([x.__str__() for x in self.pots_amounts])
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['PotsAmounts'] = self.pots_amounts

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj['PotsAmounts']
        )
