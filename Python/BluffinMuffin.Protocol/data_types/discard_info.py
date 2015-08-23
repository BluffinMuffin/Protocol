from data_types.enums.game_type_enum import GameTypeEnum
from data_types.enums.lobby_action_enum import LobbyActionEnum
from data_types.table_params import TableParams

__author__ = 'ericmas001@gmail.com'



class DiscardInfo:
    def __init__(self, obj):
        self.no_seat = obj['NoSeat']
        self.nb_cards_discarded = obj['NbCardsDiscarded']

    def __str__(self):
        return '{0}:{1}'.format(
            self.no_seat,
            self.nb_cards_discarded
        )
