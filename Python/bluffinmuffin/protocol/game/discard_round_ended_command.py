from bluffinmuffin.protocol.interfaces import AbstractGameCommand
from bluffinmuffin.protocol.data_types import DiscardInfo


class DiscardRoundEndedCommand(AbstractGameCommand):
    def __init__(self, table_id, cards_discarded):
        super().__init__(table_id)
        self.cards_discarded = cards_discarded

    def __str__(self):
        return '{0} [{1}]'.format(
            super().__str__(),
            ', '.join([x.__str__() for x in self.cards_discarded])
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['CardsDiscarded'] = [x.encode() for x in self.cards_discarded]

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            [DiscardInfo.decode(x) for x in obj['CardsDiscarded']]
        )
