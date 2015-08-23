from abstract_game_command import AbstractGameCommand
from data_types.enums.game_action_enum import GameActionEnum
from data_types.enums.player_state_enum import PlayerStateEnum

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
