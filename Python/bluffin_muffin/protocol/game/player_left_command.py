from protocol import AbstractGameCommand

__author__ = 'ericmas001@gmail.com'



class PlayerLeftCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.player_name = obj['PlayerName']

    def __str__( self ):
        return '{0} ({1})'.format(
            super().__str__(),
            self.player_name
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['PlayerName'] = self.player_name