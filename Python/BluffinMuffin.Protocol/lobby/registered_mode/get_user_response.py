from abstract_response import AbstractResponse
from lobby.registered_mode.get_user_command import GetUserCommand

__author__ = 'ericmas001@gmail.com'



class GetUserResponse(AbstractResponse):
    def __init__(self, obj):
        super().__init__(obj, GetUserCommand(obj['Command']))
        self.email = obj['Email']
        self.display_name = obj['DisplayName']
        self.money = obj['Money']

    def __str__( self ):
        return '{0} => ({1}, {2}, {3})'.format(
            super().__str__(),
            self.email,
            self.display_name,
            self.money
        )

    def _encode_specific(self, d):
        super()._encode_specific(d)
        d['Email'] = self.email
        d['DisplayName'] = self.display_name
        d['Money'] = self.money