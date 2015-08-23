from protocol import AbstractLobbyCommand

__author__ = 'ericmas001@gmail.com'



class JoinTableCommand(AbstractLobbyCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.table_id = obj['TableId']

    def __str__( self ):
        return '{0} ({1})'.format(
            super().__str__(),
            self.table_id
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['TableId'] = self.table_id