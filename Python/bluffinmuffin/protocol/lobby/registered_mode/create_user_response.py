from protocol import AbstractResponse
from create_user_command import CreateUserCommand


class CreateUserResponse(AbstractResponse):

    def __init__(self, obj):
        super().__init__(obj, CreateUserCommand(obj['Command']))
