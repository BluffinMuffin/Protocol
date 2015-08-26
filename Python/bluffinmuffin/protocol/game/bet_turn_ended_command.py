from bluffinmuffin.protocol.interfaces import AbstractGameCommand
from bluffinmuffin.protocol.enums import RoundTypeEnum


class BetTurnEndedCommand(AbstractGameCommand):

    def __init__(self, obj):
        super().__init__(obj)
        self.round = RoundTypeEnum.parse(obj['Round'])
        self.pots_amounts = obj['PotsAmounts']

    def __str__(self):
        return '{0} ({1} [{2}])'.format(
            super().__str__(),
            RoundTypeEnum.to_string(self.round),
            ', '.join([x.__str__() for x in self.pots_amounts])
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Round'] = RoundTypeEnum.to_string(self.round)
        d['PotsAmounts'] = self.pots_amounts
