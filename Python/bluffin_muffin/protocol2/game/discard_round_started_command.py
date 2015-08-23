from Python.bluffin_muffin.protocol2.abstract_game_command import AbstractGameCommand

__author__ = 'ericmas001@gmail.com'



class DiscardRoundStartedCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.minimum_cards_to_discard = obj['MinimumCardsToDiscard']
        self.maximum_cards_to_discard = obj['MaximumCardsToDiscard']

    def __str__( self ):
        return '{0} ({1}/{2})'.format(
            super().__str__(),
            self.minimum_cards_to_discard,
            self.maximum_cards_to_discard
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['MinimumCardsToDiscard'] = self.minimum_cards_to_discard
        d['MaximumCardsToDiscard'] = self.maximum_cards_to_discard