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
_print_json('{  "CommandName": "JoinTableCommand",  "TableId": 42}')
_print_json('{  "CommandName": "JoinTableResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Command": {    "CommandName": "JoinTableCommand",    "TableId": 42  }}')
_print_json('{  "CommandName": "LeaveTableCommand",  "TableId": 42}')
_print_json('{  "CommandName": "ListTableCommand",  "LobbyTypes": [    "QuickMode",    "RegisteredMode"  ]}')
_print_json('{  "CommandName": "ListTableResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Tables": [    {      "IdTable": 42,      "NbPlayers": 6,      "PossibleAction": "Join",      "Params": {        "TableName": "Bikini Bottom",        "GameType": "Holdem",        "Variant": "Texas Hold''em",        "MinPlayersToStart": 2,        "MaxPlayers": 10,        "WaitingTimes": {          "AfterPlayerAction": 500,          "AfterBoardDealed": 500,          "AfterPotWon": 2500        },        "MoneyUnit": 10,        "Lobby": {          "OptionType": "QuickMode",          "StartingAmount": 1500        },        "Blind": {          "OptionType": "Antes",          "MoneyUnit": 10        },        "Limit": {          "OptionType": "NoLimit"        }      }    },    {      "IdTable": 84,      "NbPlayers": 3,      "PossibleAction": "Leave",      "Params": {        "TableName": "Pokemon World",        "GameType": "Holdem",        "Variant": "Texas Hold''em",        "MinPlayersToStart": 2,        "MaxPlayers": 10,        "WaitingTimes": {          "AfterPlayerAction": 500,          "AfterBoardDealed": 500,          "AfterPotWon": 2500        },        "MoneyUnit": 10,        "Lobby": {          "OptionType": "QuickMode",          "StartingAmount": 1500        },        "Blind": {          "OptionType": "Blinds",          "MoneyUnit": 10        },        "Limit": {          "OptionType": "NoLimit"        }      }    }  ],  "Command": {    "CommandName": "ListTableCommand",    "LobbyTypes": [      "QuickMode",      "RegisteredMode"    ]  }}')
_print_json('{  "CommandName": "CheckCompatibilityCommand",  "ImplementedProtocolVersion": "2.0.0"}')
_print_json('{  "CommandName": "CheckCompatibilityResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "ImplementedProtocolVersion": "2.0.0",  "SupportedLobbyTypes": [    "QuickMode",    "RegisteredMode"  ],  "Rules": [    {      "GameType": "Holdem",      "Name": "Texas Hold''em",      "MinPlayers": 2,      "MaxPlayers": 10,      "AvailableLimits": [        "NoLimit"      ],      "DefaultLimit": "NoLimit",      "AvailableBlinds": [        "Blinds",        "Antes",        "None"      ],      "DefaultBlind": "Blinds",      "CanConfigWaitingTime": true,      "AvailableLobbys": [        "QuickMode",        "RegisteredMode"      ]    }  ],  "Command": {    "CommandName": "CheckCompatibilityCommand",    "ImplementedProtocolVersion": "2.0.0"  }}')
_print_json('{  "CommandName": "AuthenticateUserCommand",  "Username": "ericmas001",  "Password": "0nc3Up0nAT1m3"}')
_print_json('{  "CommandName": "AuthenticateUserResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Command": {    "CommandName": "AuthenticateUserCommand",    "Username": "ericmas001",    "Password": "0nc3Up0nAT1m3"  }}')
_print_json('{  "CommandName": "CheckDisplayExistCommand",  "DisplayName": "Sponge Bob"}')
_print_json('{  "CommandName": "CheckDisplayExistResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Exist": true,  "Command": {    "CommandName": "CheckDisplayExistCommand",    "DisplayName": "Sponge Bob"  }}')
_print_json('{  "CommandName": "CheckUserExistCommand",  "Username": "ericmas001"}')
_print_json('{  "CommandName": "CheckUserExistResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Exist": true,  "Command": {  "CommandName": "CheckUserExistCommand",  "Username": "ericmas001"}}')
_print_json('{  "CommandName": "CreateUserCommand",  "Username": "ericmas001",  "Password": "0nc3Up0nAT1m3",  "Email": "ericmas001@hotmail.com",  "DisplayName": "Sponge Bob"}')
_print_json('{  "CommandName": "CreateUserResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Command": {    "CommandName": "CreateUserCommand",    "Username": "ericmas001",    "Password": "0nc3Up0nAT1m3",    "Email": "ericmas001@hotmail.com",    "DisplayName": "Sponge Bob"  }}')
_print_json('{  "CommandName": "GetUserCommand"}')
_print_json('{  "CommandName": "GetUserResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Email": "ericmas001@hotmail.com",  "DisplayName": "Sponge Bob",  "Money": 42000.42,  "Command": {    "CommandName": "GetUserCommand"  }}')

