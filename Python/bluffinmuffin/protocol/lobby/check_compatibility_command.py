from bluffinmuffin.protocol.interfaces import AbstractLobbyCommand


class CheckCompatibilityCommand(AbstractLobbyCommand):
    def __init__(self, implemented_protocol_version, client_identification):
        super().__init__()
        self.implemented_protocol_version = implemented_protocol_version
        self.client_identification = client_identification

    def __str__(self):
        return '{0} {2} ({1})'.format(
            super().__str__(),
            self.implemented_protocol_version,
            self.client_identification
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['ImplementedProtocolVersion'] = self.implemented_protocol_version
        d['ClientIdentification'] = self.client_identification

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['ImplementedProtocolVersion'],
            obj['ClientIdentification']
        )
