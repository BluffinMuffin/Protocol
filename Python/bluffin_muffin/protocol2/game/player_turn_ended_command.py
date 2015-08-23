from Python.bluffin_muffin.protocol2.abstract_game_command import AbstractGameCommand
from game_action_enum import GameActionEnum
from player_state_enum import PlayerStateEnum

__author__ = 'ericmas001@gmail.com'



class PlayerTurnEndedCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.no_seat = obj['NoSeat']
        self.total_played_money_amount = obj['TotalPlayedMoneyAmount']
        self.total_safe_money_amount = obj['TotalSafeMoneyAmount']
        self.total_pot = obj['TotalPot']
        self.action_taken_type = GameActionEnum.parse(obj['ActionTakenType'])
        self.action_taken_amount = obj['ActionTakenAmount']
        self.player_state = PlayerStateEnum.parse(obj['PlayerState'])

    def __str__( self ):
        return '{0} ({1} {2}/{3} {4} {5}:{6} {7})'.format(
            super().__str__(),
            self.no_seat,
            self.total_played_money_amount,
            self.total_safe_money_amount,
            self.total_pot,
            GameActionEnum.to_string(self.action_taken_type),
            self.action_taken_amount,
            PlayerStateEnum.to_string(self.player_state)
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['NoSeat'] = self.no_seat
        d['TotalPlayedMoneyAmount'] = self.total_played_money_amount
        d['TotalSafeMoneyAmount'] = self.total_safe_money_amount
        d['TotalPot'] = self.total_pot
        d['ActionTakenType'] = GameActionEnum.to_string(self.action_taken_type)
        d['ActionTakenAmount'] = self.action_taken_amount
        d['PlayerState'] = PlayerStateEnum.to_string(self.player_state)