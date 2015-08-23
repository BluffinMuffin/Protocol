from abstract_game_command import AbstractGameCommand

__author__ = 'ericmas001@gmail.com'



class PlayerDiscardActionCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.cards_discarded = obj['CardsDiscarded']

    def __str__( self ):
        return '{0} [{1}]'.format(super().__str__(), ', '.join(self.cards_discarded))
