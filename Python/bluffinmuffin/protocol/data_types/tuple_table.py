from collections import OrderedDict

from bluffinmuffin.protocol.enums import LobbyActionEnum
from .table_params import TableParams


class TupleTable:
    def __init__(self, id_table, nb_players, possible_action, params):
        self.id_table = id_table
        self.nb_players = nb_players
        self.possible_action = possible_action
        self.params = params

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

    @classmethod
    def decode(cls, obj):
        return cls(
            obj["IdTable"],
            obj["NbPlayers"],
            LobbyActionEnum.parse(obj['PossibleAction']),
            TableParams.decode(obj['Params'])
        )
