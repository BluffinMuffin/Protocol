from collections import OrderedDict
from data_types.enums.player_state_enum import PlayerStateEnum

__author__ = 'ericmas001@gmail.com'



class PlayerInfo:
    def __init__(self, obj):
        self.no_seat = obj['NoSeat']
        self.name = obj['Name']
        self.money_safe_amount = obj['MoneySafeAmnt']
        self.money_bet_amount = obj['MoneyBetAmnt']
        self.hole_cards = obj['HoleCards']
        self.state = PlayerStateEnum.parse(obj['State'])
        self.is_showing_cards = obj['IsShowingCards']

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
