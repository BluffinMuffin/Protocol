from abstract_game_command import AbstractGameCommand
from data_types.discard_info import DiscardInfo

__author__ = 'ericmas001@gmail.com'



class DiscardRoundEndedCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.cards_discarded = [DiscardInfo(x) for x in obj['CardsDiscarded']]

    def __str__( self ):
        return '{0} [{1}]'.format(super().__str__(), ', '.join([x.__str__() for x in self.cards_discarded]))
