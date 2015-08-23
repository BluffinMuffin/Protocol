from protocol import AbstractGameCommand
from round_type_enum import RoundTypeEnum

__author__ = 'ericmas001@gmail.com'



class BetTurnStartedCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.round = RoundTypeEnum.parse(obj['Round'])
        self.betting_round_id = obj['BettingRoundId']
        self.cards = obj['Cards']

    def __str__( self ):
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