from collections import OrderedDict


class ConfigurableWaitingTimes:

    def __init__(self, obj):
        self.after_player_action = obj['AfterPlayerAction']
        self.after_board_dealed = obj['AfterBoardDealed']
        self.after_pot_won = obj['AfterPotWon']

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
