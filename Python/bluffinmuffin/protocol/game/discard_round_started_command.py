from bluffinmuffin.protocol.interfaces import AbstractGameCommand


class DiscardRoundStartedCommand(AbstractGameCommand):
    def __init__(self, table_id, minimum_cards_to_discard, maximum_cards_to_discard):
        super().__init__(table_id)
        self.minimum_cards_to_discard = minimum_cards_to_discard
        self.maximum_cards_to_discard = maximum_cards_to_discard

    def __str__(self):
        return '{0} ({1}/{2})'.format(
            super().__str__(),
            self.minimum_cards_to_discard,
            self.maximum_cards_to_discard
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['MinimumCardsToDiscard'] = self.minimum_cards_to_discard
        d['MaximumCardsToDiscard'] = self.maximum_cards_to_discard

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj['MinimumCardsToDiscard'],
            obj['MaximumCardsToDiscard']
        )
