from bluffinmuffin.protocol.interfaces import AbstractGameCommand
from bluffinmuffin.protocol.enums import RoundTypeEnum


class BetTurnEndedCommand(AbstractGameCommand):

    def __init__(self, table_id, round, pots_amounts):
        super().__init__(table_id)
        self.round = round
        self.pots_amounts = pots_amounts

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

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            RoundTypeEnum.parse(obj['Round']),
            obj['PotsAmounts']
        )
