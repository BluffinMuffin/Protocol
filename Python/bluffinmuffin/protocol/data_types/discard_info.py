from collections import OrderedDict


class DiscardInfo:
    def __init__(self, no_seat, nb_cards_discarded):
        self.no_seat = no_seat
        self.nb_cards_discarded = nb_cards_discarded

    def __str__(self):
        return '{0}:{1}'.format(
            self.no_seat,
            self.nb_cards_discarded
        )

    def encode(self):
        d = OrderedDict()
        d['NoSeat'] = self.no_seat
        d['NbCardsDiscarded'] = self.nb_cards_discarded
        return d

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["NoSeat"],
            obj['NbCardsDiscarded']
        )
