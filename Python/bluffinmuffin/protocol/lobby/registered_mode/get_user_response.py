from bluffinmuffin.protocol.enums import BluffinMessageIdEnum
from bluffinmuffin.protocol.interfaces import AbstractResponse
from .get_user_command import GetUserCommand


class GetUserResponse(AbstractResponse):
    def __init__(self, success, message_id, message, jsonCommand, email, display_name, money):
        super().__init__(success, message_id, message, GetUserCommand.decode(jsonCommand))
        self.email = email
        self.display_name = display_name
        self.money = money

    def __str__(self):
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

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Success'],
            BluffinMessageIdEnum.parse(obj['MessageId']),
            obj['Message'],
            obj['Command'],
            obj['Email'],
            obj['DisplayName'],
            obj['Money']
        )
