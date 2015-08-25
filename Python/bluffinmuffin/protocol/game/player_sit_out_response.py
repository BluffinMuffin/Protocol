from protocol import AbstractGameResponse
from player_sit_out_command import PlayerSitOutCommand


class PlayerSitOutResponse(AbstractGameResponse):
    def __init__(self, obj):
        super().__init__(obj, PlayerSitOutCommand(obj['Command']))
