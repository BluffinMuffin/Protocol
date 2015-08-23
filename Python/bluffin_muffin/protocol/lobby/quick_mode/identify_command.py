from protocol import AbstractLobbyCommand

__author__ = 'ericmas001@gmail.com'



class IdentifyCommand(AbstractLobbyCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.name = obj['Name']

    def __str__( self ):
        return '{0} ({1})'.format(
            super().__str__(),
            self.name
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Name'] = self.name