from data_types.enums.game_type_enum import GameTypeEnum
from data_types.enums.lobby_action_enum import LobbyActionEnum
from data_types.table_params import TableParams

__author__ = 'ericmas001@gmail.com'



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
