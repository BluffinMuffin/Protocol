from bluffinmuffin.protocol.interfaces import AbstractGameCommand
from bluffinmuffin.protocol.enums import PokerHandEnum


class PlayerWonPotCommand(AbstractGameCommand):
    def __init__(self, table_id, no_seat, pot_id, won_amount, total_pot_amount, total_player_money, winning_cards,
                 winning_hand):
        super().__init__(table_id)
        self.no_seat = no_seat
        self.pot_id = pot_id
        self.won_amount = won_amount
        self.total_pot_amount = total_pot_amount
        self.total_player_money = total_player_money
        self.winning_cards = winning_cards
        self.winning_hand = winning_hand

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

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj["NoSeat"],
            obj["PotId"],
            obj["WonAmount"],
            obj["TotalPotAmount"],
            obj["TotalPlayerMoney"],
            obj["WinningCards"],
            PokerHandEnum.parse(obj['WinningHand'])
        )
