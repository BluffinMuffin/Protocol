from protocol import AbstractResponse
from authenticate_user_command import AuthenticateUserCommand


class AuthenticateUserResponse(AbstractResponse):
    def __init__(self, obj):
        super().__init__(obj, AuthenticateUserCommand(obj['Command']))
