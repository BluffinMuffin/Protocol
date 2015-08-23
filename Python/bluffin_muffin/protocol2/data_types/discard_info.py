from collections import OrderedDict

__author__ = 'ericmas001@gmail.com'



class DiscardInfo:
    def __init__(self, obj):
        self.no_seat = obj['NoSeat']
        self.nb_cards_discarded = obj['NbCardsDiscarded']

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
