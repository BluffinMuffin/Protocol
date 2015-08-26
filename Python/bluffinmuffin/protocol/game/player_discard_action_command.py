from protocol import AbstractGameCommand


class PlayerDiscardActionCommand(AbstractGameCommand):

    def __init__(self, obj):
        super().__init__(obj)
        self.cards_discarded = obj['CardsDiscarded']

    def __str__(self):
        return '{0} [{1}]'.format(
            super().__str__(),
            ', '.join(self.cards_discarded)
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['CardsDiscarded'] = self.cards_discarded
