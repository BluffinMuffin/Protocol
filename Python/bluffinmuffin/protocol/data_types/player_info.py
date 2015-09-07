from collections import OrderedDict

from bluffinmuffin.protocol.enums import PlayerStateEnum


class PlayerInfo:
    def __init__(self, no_seat, name, money_safe_amount, money_bet_amount, hole_cards, state, is_showing_cards):
        self.no_seat = no_seat
        self.name = name
        self.money_safe_amount = money_safe_amount
        self.money_bet_amount = money_bet_amount
        self.hole_cards = hole_cards
        self.state = state
        self.is_showing_cards = is_showing_cards

    def __str__(self):
        return '{0}:{1} {2}/{3} [{4}] {5}'.format(
            self.no_seat,
            self.name,
            self.money_bet_amount,
            self.money_safe_amount,
            ', '.join(self.hole_cards),
            PlayerStateEnum.to_string(self.state),
            self.is_showing_cards
        )

    def encode(self):
        d = OrderedDict()
        d['NoSeat'] = self.no_seat
        d['Name'] = self.name
        d['MoneySafeAmnt'] = self.money_safe_amount
        d['MoneyBetAmnt'] = self.money_bet_amount
        d['HoleCards'] = self.hole_cards
        d['State'] = PlayerStateEnum.to_string(self.state)
        d['IsShowingCards'] = self.is_showing_cards
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
            obj["HoleCards"],
            PlayerStateEnum.parse(obj['State']),
            obj['IsShowingCards']
        )
