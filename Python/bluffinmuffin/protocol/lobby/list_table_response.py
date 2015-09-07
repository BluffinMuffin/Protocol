from bluffinmuffin.protocol.enums import BluffinMessageIdEnum
from bluffinmuffin.protocol.interfaces import AbstractResponse
from bluffinmuffin.protocol.data_types import TupleTable
from .list_table_command import ListTableCommand


class ListTableResponse(AbstractResponse):

    def __init__(self, success, message_id, message, jsonCommand,tables):
        super().__init__(success, message_id, message, ListTableCommand.decode(jsonCommand))
        self.tables = tables

    def __str__(self):
        return '{0} => ({1})'.format(
            super().__str__(),
            ', '.join([x.__str__() for x in self.tables])
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Tables'] = [x.encode() for x in self.tables]

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Success'],
            BluffinMessageIdEnum.parse(obj['MessageId']),
            obj['Message'],
            obj['Command'],
            [TupleTable(x) for x in obj['Tables']]
        )
