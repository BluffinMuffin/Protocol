from abstract_response import AbstractResponse
from lobby.join_table_command import JoinTableCommand

__author__ = 'ericmas001@gmail.com'



class JoinTableResponse(AbstractResponse):
    def __init__(self, obj):
        super().__init__(obj, JoinTableCommand(obj['Command']))