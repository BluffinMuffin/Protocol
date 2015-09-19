from collections import OrderedDict

from bluffinmuffin.protocol.enums import PlayerStateEnum


class PlayerInfo:
    def __init__(self, no_seat, name, money_safe_amount, money_bet_amount, face_up_cards, face_down_cards, state):
        self.no_seat = no_seat
        self.name = name
        self.money_safe_amount = money_safe_amount
        self.money_bet_amount = money_bet_amount
        self.face_up_cards = face_up_cards
        self.face_down_cards = face_down_cards
        self.state = state

    def __str__(self):
        return '{0}:{1} {2}/{3} [{4} | {5}] {6}'.format(
            self.no_seat,
            self.name,
            self.money_bet_amount,
            self.money_safe_amount,
            ', '.join(self.face_up_cards),
            ', '.join(self.face_down_cards),
            PlayerStateEnum.to_string(self.state)
        )

    def encode(self):
        d = OrderedDict()
        d['NoSeat'] = self.no_seat
        d['Name'] = self.name
        d['MoneySafeAmnt'] = self.money_safe_amount
        d['MoneyBetAmnt'] = self.money_bet_amount
        d['FaceUpCards'] = self.face_up_cards
        d['FaceDownCards'] = self.face_down_cards
        d['State'] = PlayerStateEnum.to_string(self.state)
        return d

    @classmethod
    def decode(cls, obj):
        if obj == None:
            return None
        return cls(
            obj["NoSeat"],
            obj["Name"],
            obj["MoneySafeAmnt"],
            obj["MoneyBetAmnt"],
            obj["FaceUpCards"],
            obj["FaceDownCards"],
            PlayerStateEnum.parse(obj['State'])
        )
