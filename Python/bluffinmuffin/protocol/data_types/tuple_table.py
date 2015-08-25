from collections import OrderedDict

from lobby_action_enum import LobbyActionEnum
from data_types.table_params import TableParams


class TupleTable:
    def __init__(self, obj):
        self.id_table = obj['IdTable']
        self.nb_players = obj['NbPlayers']
        self.possible_action = LobbyActionEnum.parse(obj['PossibleAction'])
        self.params = TableParams(obj['Params'])

    def __str__(self):
        return '{0}({1}) {2} [{3}]'.format(
            self.id_table,
            self.nb_players,
            LobbyActionEnum.to_string(self.possible_action),
            self.params
        )

    def encode(self):
        d = OrderedDict()
        d['IdTable'] = self.id_table
        d['NbPlayers'] = self.nb_players
        d['PossibleAction'] = LobbyActionEnum.to_string(self.possible_action)
        d['Params'] = self.params.encode()
        return d
