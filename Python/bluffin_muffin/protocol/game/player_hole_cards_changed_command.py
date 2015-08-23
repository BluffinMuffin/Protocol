from protocol import AbstractGameCommand
from player_state_enum import PlayerStateEnum

__author__ = 'ericmas001@gmail.com'



class PlayerHoleCardsChangedCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.no_seat = obj['NoSeat']
        self.cards = obj['Cards']
        self.player_state = PlayerStateEnum.parse(obj['PlayerState'])

    def __str__( self ):
        return '{0} ({1} [{2}] {3})'.format(
            super().__str__(),
            self.no_seat,
            ', '.join(self.cards),
            PlayerStateEnum.to_string(self.player_state)
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['NoSeat'] = self.no_seat
        d['Cards'] = self.cards
        d['PlayerState'] = PlayerStateEnum.to_string(self.player_state)