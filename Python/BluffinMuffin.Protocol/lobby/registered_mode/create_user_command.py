from abstract_lobby_command import AbstractLobbyCommand

__author__ = 'ericmas001@gmail.com'



class CreateUserCommand(AbstractLobbyCommand):
    def __init__(self, obj):
        super().__init__(obj)
        self.username = obj['Username']
        self.password = obj['Password']
        self.email = obj['Email']
        self.display_name = obj['DisplayName']

    def __str__( self ):
        return '{0} ({1} : {2}, {3}, {4})'.format(super().__str__(), self.username, self.password, self.email, self.display_name)
