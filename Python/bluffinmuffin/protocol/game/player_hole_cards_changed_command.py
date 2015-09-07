from bluffinmuffin.protocol.interfaces import AbstractGameCommand
from bluffinmuffin.protocol.enums import PlayerStateEnum


class PlayerHoleCardsChangedCommand(AbstractGameCommand):

    def __init__(self, table_id, no_seat, cards, player_state):
        super().__init__(table_id)
        self.no_seat = no_seat
        self.cards = cards
        self.player_state = player_state

    def __str__(self):
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

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj['NoSeat'],
            obj['Cards'],
            PlayerStateEnum.parse(obj['PlayerState'])
        )
