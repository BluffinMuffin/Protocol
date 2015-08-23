from abstract_response import AbstractResponse
from lobby.registered_mode.authenticate_user_command import AuthenticateUserCommand

__author__ = 'ericmas001@gmail.com'



class AuthenticateUserResponse(AbstractResponse):
    def __init__(self, obj):
        super().__init__(obj, AuthenticateUserCommand(obj['Command']))