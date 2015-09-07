from bluffinmuffin.protocol.interfaces import AbstractGameCommand
from bluffinmuffin.protocol.enums import RoundTypeEnum


class BetTurnStartedCommand(AbstractGameCommand):
    def __init__(self, table_id, round, betting_round_id, cards):
        super().__init__(table_id)
        self.round = round
        self.betting_round_id = betting_round_id
        self.cards = cards

    def __str__(self):
        return '{0} ({1}:{2} [{3}])'.format(
            super().__str__(),
            self.betting_round_id,
            RoundTypeEnum.to_string(self.round),
            ', '.join(self.cards)
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Round'] = RoundTypeEnum.to_string(self.round)
        d['BettingRoundId'] = self.betting_round_id
        d['Cards'] = self.cards

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            RoundTypeEnum.parse(obj['Round']),
            obj['BettingRoundId'],
            obj['Cards']
        )
