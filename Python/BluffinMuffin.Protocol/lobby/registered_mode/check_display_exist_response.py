from abstract_response import AbstractResponse
from lobby.registered_mode.authenticate_user_command import AuthenticateUserCommand
from lobby.registered_mode.check_display_exist_command import CheckDisplayExistCommand

__author__ = 'ericmas001@gmail.com'



class CheckDisplayExistResponse(AbstractResponse):
    def __init__(self, obj):
        super().__init__(obj, CheckDisplayExistCommand(obj['Command']))
        self.exist = obj['Exist']

    def __str__( self ):
        return '{0} => {1}'.format(super().__str__(), self.exist)