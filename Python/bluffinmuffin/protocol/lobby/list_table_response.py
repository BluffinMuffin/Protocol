from protocol import AbstractResponse
from tuple_table import TupleTable
from list_table_command import ListTableCommand


class ListTableResponse(AbstractResponse):
    def __init__(self, obj):
        super().__init__(obj, ListTableCommand(obj['Command']))
        self.tables = [TupleTable(x) for x in obj['Tables']]

    def __str__(self):
        return '{0} => ({1})'.format(
            super().__str__(),
            ', '.join([x.__str__() for x in self.tables])
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Tables'] = [x.encode() for x in self.tables]
