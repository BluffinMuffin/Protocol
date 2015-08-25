from protocol import AbstractGameCommand


class PlayerPlayMoneyCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.amount_played = obj['AmountPlayed']

    def __str__(self):
        return '{0} ({1})'.format(
            super().__str__(),
            self.amount_played
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['AmountPlayed'] = self.amount_played
