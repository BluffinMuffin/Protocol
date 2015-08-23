from command_decoder import CommandDecoder
import json

__author__ = 'ericmas001@gmail.com'

def _print_json(str):
    j = json.loads(str)
    command = CommandDecoder.decode(j)
    print(command)

_print_json('{  "CommandName": "DisconnectCommand"}')
_print_json('{  "CommandName": "IdentifyCommand",  "Name": "SpongeBob"}')
_print_json('{  "CommandName": "IdentifyResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Command": {    "CommandName": "IdentifyCommand",    "Name": "SpongeBob"  }}')
_print_json('{  "CommandName": "IdentifyResponse",  "Success": false,  "MessageId": "NameAlreadyUsed",  "Message": "The name SpongeBob was already used!",  "Command": {    "CommandName": "IdentifyCommand",    "Name": "SpongeBob"  }}')
_print_json('{  "CommandName": "CreateTableCommand",  "Params": {    "TableName": "Bikini Bottom",    "GameType": "Holdem",    "Variant": "Texas Hold''em",    "MinPlayersToStart": 2,    "MaxPlayers": 10,    "WaitingTimes": {      "AfterPlayerAction": 500,      "AfterBoardDealed": 500,      "AfterPotWon": 2500    },    "MoneyUnit": 10,    "Lobby": {      "OptionType": "QuickMode",      "StartingAmount": 1500    },    "Blind": {      "OptionType": "Blinds",      "MoneyUnit": 10    },    "Limit": {      "OptionType": "NoLimit"    }  }}')
_print_json('{  "CommandName": "CreateTableResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "IdTable": 42,  "Command": {    "CommandName": "CreateTableCommand",    "Params": {      "TableName": "Bikini Bottom",      "GameType": "Holdem",      "Variant": "Texas Hold''em",      "MinPlayersToStart": 2,      "MaxPlayers": 10,      "WaitingTimes": {        "AfterPlayerAction": 500,        "AfterBoardDealed": 500,        "AfterPotWon": 2500      },      "MoneyUnit": 10,      "Lobby": {        "OptionType": "QuickMode",        "StartingAmount": 1500      },      "Blind": {        "OptionType": "Blinds",        "MoneyUnit": 0      },      "Limit": {        "OptionType": "NoLimit"      }    }  }}')