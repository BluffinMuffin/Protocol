from Python.bluffin_muffin.protocol.abstract_response import AbstractResponse
from create_user_command import CreateUserCommand

__author__ = 'ericmas001@gmail.com'



class CreateUserResponse(AbstractResponse):
    def __init__(self, obj):
        super().__init__(obj, CreateUserCommand(obj['Command']))