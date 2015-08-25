from protocol import AbstractResponse
from join_table_command import JoinTableCommand


class JoinTableResponse(AbstractResponse):
    def __init__(self, obj):
        super().__init__(obj, JoinTableCommand(obj['Command']))
