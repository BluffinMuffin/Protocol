from bluffinmuffin.protocol.enums import BluffinMessageIdEnum
from bluffinmuffin.protocol.interfaces import AbstractResponse
from .create_table_command import CreateTableCommand


class CreateTableResponse(AbstractResponse):
    def __init__(self, success, message_id, message, jsonCommand, id_table):
        super().__init__(success, message_id, message, CreateTableCommand.decode(jsonCommand))
        self.id_table = id_table

    def __str__(self):
        return '{0} => {1}'.format(
            super().__str__(),
            self.id_table
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['IdTable'] = self.id_table

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Success'],
            BluffinMessageIdEnum.parse(obj['MessageId']),
            obj['Message'],
            obj['Command'],
            obj['IdTable']
        )
