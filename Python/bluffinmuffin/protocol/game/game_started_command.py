from protocol import AbstractGameCommand


class GameStartedCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.needed_blind_amount = obj['NeededBlindAmount']

    def __str__(self):
        return '{0} ({1})'.format(
            super().__str__(),
            self.needed_blind_amount
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['NeededBlindAmount'] = self.needed_blind_amount
