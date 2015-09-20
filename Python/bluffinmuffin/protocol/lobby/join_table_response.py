from bluffinmuffin.protocol.enums import BluffinMessageIdEnum
from bluffinmuffin.protocol.interfaces import AbstractResponse
from .join_table_command import JoinTableCommand
from bluffinmuffin.protocol.data_types import SeatInfo
from bluffinmuffin.protocol.data_types import TableParams


class JoinTableResponse(AbstractResponse):
    def __init__(self, success, message_id, message, jsonCommand, params, total_pot_amount, pots_amount, board_cards, seats, game_has_started):
        super().__init__(success, message_id, message, JoinTableCommand.decode(jsonCommand))
        self.params = params
        self.total_pot_amount = total_pot_amount
        self.pots_amount = pots_amount
        self.board_cards = board_cards
        self.seats = seats
        self.game_has_started = game_has_started

    def __str__(self):
        return '{0} => ({1}) {2} [{3}] [{4}] [{5}] {6}'.format(
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

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Success'],
            BluffinMessageIdEnum.parse(obj['MessageId']),
            obj['Message'],
            obj['Command'],
            TableParams.decode(obj['Params']),
            obj["TotalPotAmount"],
            obj["PotsAmount"],
            obj["BoardCards"],
            [SeatInfo.decode(x) for x in obj['Seats']],
            obj['GameHasStarted']
        )
