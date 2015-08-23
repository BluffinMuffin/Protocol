from Python.bluffin_muffin.protocol2.abstract_lobby_command import AbstractLobbyCommand

__author__ = 'ericmas001@gmail.com'



class CheckDisplayExistCommand(AbstractLobbyCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.display_name = obj['DisplayName']

    def __str__( self ):
        return '{0} ({1})'.format(
            super().__str__(),
            self.display_name
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['DisplayName'] = self.display_name
