from CommandDecoder import CommandDecoder
import json

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

def print_json(str):
    j = json.loads(str)
    command = CommandDecoder.decode(j)
    print(command)

print_json('{  "CommandName": "DisconnectCommand"}')
print_json('{  "CommandName": "IdentifyCommand",  "Name": "SpongeBob"}')
print_json('{  "CommandName": "IdentifyResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Command": {    "CommandName": "IdentifyCommand",    "Name": "SpongeBob"  }}')
print_json('{  "CommandName": "IdentifyResponse",  "Success": false,  "MessageId": "NameAlreadyUsed",  "Message": "The name SpongeBob was already used!",  "Command": {    "CommandName": "IdentifyCommand",    "Name": "SpongeBob"  }}')
