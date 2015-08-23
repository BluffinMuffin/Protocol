from abstract_game_command import AbstractGameCommand
from data_types.enums.poker_hand_enum import PokerHandEnum

__author__ = 'ericmas001@gmail.com'



class PlayerWonPotCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.no_seat = obj['NoSeat']
        self.pot_id = obj['PotId']
        self.won_amount = obj['WonAmount']
        self.total_pot_amount = obj['TotalPotAmount']
        self.total_player_money = obj['TotalPlayerMoney']
        self.winning_cards = obj['WinningCards']
        self.winnind_hand = PokerHandEnum.parse(obj['WinningHand'])

    def __str__( self ):
        return '{0} ({1}, {2}, {3}, {4}, {5} [{6}] {7})'.format(
            super().__str__(),
            self.no_seat,
            self.pot_id,
            self.won_amount,
            self.total_pot_amount,
            self.total_player_money,
            ', '.join(self.winning_cards),
            PokerHandEnum.to_string(self.winnind_hand)
        )
