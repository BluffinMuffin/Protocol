from bluffinmuffin.protocol.interfaces import AbstractGameCommand
from bluffinmuffin.protocol.enums import PlayerStateEnum


class PlayerHoleCardsChangedCommand(AbstractGameCommand):
    def __init__(self, table_id, no_seat, face_up_cards, face_down_cards, player_state):
        super().__init__(table_id)
        self.no_seat = no_seat
        self.face_up_cards = face_up_cards
        self.face_down_cards = face_down_cards
        self.player_state = player_state

    def __str__(self):
        return '{0} ({1} [{2}] [{3}] {4})'.format(
            super().__str__(),
            self.no_seat,
            ', '.join(self.face_up_cards),
            ', '.join(self.face_down_cards),
            PlayerStateEnum.to_string(self.player_state)
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['NoSeat'] = self.no_seat
        d['FaceUpCards'] = self.face_up_cards
        d['FaceDownCards'] = self.face_down_cards
        d['PlayerState'] = PlayerStateEnum.to_string(self.player_state)

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj['NoSeat'],
            obj['FaceUpCards'],
            obj['FaceDownCards'],
            PlayerStateEnum.parse(obj['PlayerState'])
        )
