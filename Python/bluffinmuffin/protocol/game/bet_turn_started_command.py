from bluffinmuffin.protocol.interfaces import AbstractGameCommand
from bluffinmuffin.protocol.data_types import SeatInfo


class BetTurnStartedCommand(AbstractGameCommand):
    def __init__(self, table_id, betting_round_id, cards, seats):
        super().__init__(table_id)
        self.betting_round_id = betting_round_id
        self.cards = cards
        self.seats = seats

    def __str__(self):
        return '{0} ({1} [{2}] [{3}])'.format(
            super().__str__(),
            self.betting_round_id,
            ', '.join(self.cards),
            ', '.join([x.__str__() for x in self.seats])
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['BettingRoundId'] = self.betting_round_id
        d['Cards'] = self.cards
        d['Seats'] = [x.encode() for x in self.seats]

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj['BettingRoundId'],
            obj['Cards'],
            [SeatInfo.decode(x) for x in obj['Seats']]
        )
