from bluffinmuffin.protocol.interfaces import AbstractGameCommand


class PlayerDiscardActionCommand(AbstractGameCommand):
    def __init__(self, table_id, cards_discarded):
        super().__init__(table_id)
        self.cards_discarded = cards_discarded

    def __str__(self):
        return '{0} [{1}]'.format(
            super().__str__(),
            ', '.join(self.cards_discarded)
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['CardsDiscarded'] = self.cards_discarded

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj['CardsDiscarded']
        )
