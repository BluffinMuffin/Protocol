from bluffinmuffin.protocol.interfaces import AbstractGameCommand
from bluffinmuffin.protocol.enums import GameActionEnum
from bluffinmuffin.protocol.enums import PlayerStateEnum


class PlayerTurnEndedCommand(AbstractGameCommand):
    def __init__(self, table_id, no_seat, total_played_money_amount, total_safe_money_amount, total_pot,
                 action_taken_type, action_taken_amount, player_state):
        super().__init__(table_id)
        self.no_seat = no_seat
        self.total_played_money_amount = total_played_money_amount
        self.total_safe_money_amount = total_safe_money_amount
        self.total_pot = total_pot
        self.action_taken_type = action_taken_type
        self.action_taken_amount = action_taken_amount
        self.player_state = player_state

    def __str__(self):
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

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["TableId"],
            obj["NoSeat"],
            obj["TotalPlayedMoneyAmount"],
            obj["TotalSafeMoneyAmount"],
            obj["TotalPot"],
            GameActionEnum.parse(obj['ActionTakenType']),
            obj["ActionTakenAmount"],
            PlayerStateEnum.parse(obj['PlayerState'])
        )
