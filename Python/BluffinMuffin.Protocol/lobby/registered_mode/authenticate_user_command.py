from abstract_lobby_command import AbstractLobbyCommand

__author__ = 'ericmas001@gmail.com'



class AuthenticateUserCommand(AbstractLobbyCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.username = obj['Username']
        self.password = obj['Password']

    def __str__( self ):
        return '{0} ({1} : {2})'.format(super().__str__(), self.username, self.password)
