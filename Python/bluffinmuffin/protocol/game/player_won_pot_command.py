from bluffinmuffin.protocol.interfaces import AbstractGameCommand
from bluffinmuffin.protocol.enums import PokerHandEnum


class PlayerWonPotCommand(AbstractGameCommand):

    def __init__(self, obj):
        super().__init__(obj)
        self.no_seat = obj['NoSeat']
        self.pot_id = obj['PotId']
        self.won_amount = obj['WonAmount']
        self.total_pot_amount = obj['TotalPotAmount']
        self.total_player_money = obj['TotalPlayerMoney']
        self.winning_cards = obj['WinningCards']
        self.winning_hand = PokerHandEnum.parse(obj['WinningHand'])

    def __str__(self):
        return '{0} ({1}, {2}, {3}, {4}, {5} [{6}] {7})'.format(
            super().__str__(),
            self.no_seat,
            self.pot_id,
            self.won_amount,
            self.total_pot_amount,
            self.total_player_money,
            ', '.join(self.winning_cards),
            PokerHandEnum.to_string(self.winning_hand)
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['NoSeat'] = self.no_seat
        d['PotId'] = self.pot_id
        d['WonAmount'] = self.won_amount
        d['TotalPotAmount'] = self.total_pot_amount
        d['TotalPlayerMoney'] = self.total_player_money
        d['WinningCards'] = self.winning_cards
        d['WinningHand'] = PokerHandEnum.to_string(self.winning_hand)
