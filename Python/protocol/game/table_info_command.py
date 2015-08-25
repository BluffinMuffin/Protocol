from protocol import AbstractGameCommand
from seat_info import SeatInfo
from table_params import TableParams


class TableInfoCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.params = TableParams(obj['Params'])
        self.total_pot_amount = obj['TotalPotAmount']
        self.pots_amount = obj['PotsAmount']
        self.board_cards = obj['BoardCards']
        self.seats = [SeatInfo(x) for x in obj['Seats']]
        self.game_has_started = obj['GameHasStarted']

    def __str__(self):
        return '{0} ({1}) {2} [{3}] [{4}] [{5}] {6}'.format(
            super().__str__(),
            self.params,
            self.total_pot_amount,
            ', '.join([x.__str__() for x in self.pots_amount]),
            ', '.join(self.board_cards),
            ', '.join([x.__str__() for x in self.seats]),
            self.game_has_started
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Params'] = self.params.encode()
        d['TotalPotAmount'] = self.total_pot_amount
        d['PotsAmount'] = self.pots_amount
        d['BoardCards'] = self.board_cards
        d['Seats'] = [x.encode() for x in self.seats]
        d['GameHasStarted'] = self.game_has_started
