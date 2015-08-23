from abstract_response import AbstractResponse
from lobby.registered_mode.create_user_command import CreateUserCommand

__author__ = 'ericmas001@gmail.com'



class CreateUserResponse(AbstractResponse):
    def __init__(self, obj):
        super().__init__(obj, CreateUserCommand(obj['Command']))