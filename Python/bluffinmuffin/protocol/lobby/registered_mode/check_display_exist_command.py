from bluffinmuffin.protocol.interfaces import AbstractLobbyCommand


class CheckDisplayExistCommand(AbstractLobbyCommand):

    def __init__(self, obj):
        super().__init__(obj)
        self.display_name = obj['DisplayName']

    def __str__(self):
        return '{0} ({1})'.format(
            super().__str__(),
            self.display_name
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['DisplayName'] = self.display_name
