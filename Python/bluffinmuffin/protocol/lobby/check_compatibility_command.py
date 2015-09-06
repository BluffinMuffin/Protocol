from bluffinmuffin.protocol.interfaces import AbstractLobbyCommand


class CheckCompatibilityCommand(AbstractLobbyCommand):

    def __init__(self, implemented_protocol_version):
        super().__init__()
        self.implemented_protocol_version = implemented_protocol_version

    def __str__(self):
        return '{0} ({1})'.format(
            super().__str__(),
            self.implemented_protocol_version
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['ImplementedProtocolVersion'] = self.implemented_protocol_version

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['ImplementedProtocolVersion']
        )
