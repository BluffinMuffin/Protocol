from collections import OrderedDict


class ConfigurableWaitingTimes:

    def __init__(self, after_player_action,after_board_dealed,after_pot_won):
        self.after_player_action = after_player_action
        self.after_board_dealed = after_board_dealed
        self.after_pot_won = after_pot_won

    def __str__(self):
        return '({0},{1},{2})'.format(
            self.after_player_action,
            self.after_board_dealed,
            self.after_pot_won
        )

    def encode(self):
        d = OrderedDict()
        d['AfterPlayerAction'] = self.after_player_action
        d['AfterBoardDealed'] = self.after_board_dealed
        d['AfterPotWon'] = self.after_pot_won
        return d

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["AfterPlayerAction"],
            obj['AfterBoardDealed'],
            obj['AfterPotWon']
        )
