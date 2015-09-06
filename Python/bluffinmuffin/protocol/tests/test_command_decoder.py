import json

from nose.tools import assert_equal
from numpy.testing import run_module_suite

from bluffinmuffin.protocol import CommandDecoder


def test_command_decoder():
    def assert_command(msg):
        j = json.loads(msg)
        command = CommandDecoder.decode(j)
        assert_equal(json.loads(command.encode()), j)

    assert_command('{  "CommandName": "DisconnectCommand"}')
    assert_command('{  "CommandName": "IdentifyCommand",  "Name": "SpongeBob"}')
    assert_command('{  "CommandName": "IdentifyResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Command": {    "CommandName": "IdentifyCommand",    "Name": "SpongeBob"  }}')
    assert_command('{  "CommandName": "IdentifyResponse",  "Success": false,  "MessageId": "NameAlreadyUsed",  "Message": "The name SpongeBob was already used!",  "Command": {    "CommandName": "IdentifyCommand",    "Name": "SpongeBob"  }}')
    assert_command('{  "CommandName": "CreateTableCommand",  "Params": {    "TableName": "Bikini Bottom",    "GameType": "Holdem",    "Variant": "Texas Hold\'em",    "MinPlayersToStart": 2,    "MaxPlayers": 10,    "WaitingTimes": {      "AfterPlayerAction": 500,      "AfterBoardDealed": 500,      "AfterPotWon": 2500    },    "MoneyUnit": 10,    "Lobby": {      "OptionType": "QuickMode",      "StartingAmount": 1500    },    "Blind": {      "OptionType": "Blinds",      "MoneyUnit": 10    },    "Limit": {      "OptionType": "NoLimit"    }  }}')
    assert_command('{  "CommandName": "CreateTableResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "IdTable": 42,  "Command": {    "CommandName": "CreateTableCommand",    "Params": {      "TableName": "Bikini Bottom",      "GameType": "Holdem",      "Variant": "Texas Hold\'em",      "MinPlayersToStart": 2,      "MaxPlayers": 10,      "WaitingTimes": {        "AfterPlayerAction": 500,        "AfterBoardDealed": 500,        "AfterPotWon": 2500      },      "MoneyUnit": 10,      "Lobby": {        "OptionType": "QuickMode",        "StartingAmount": 1500      },      "Blind": {        "OptionType": "Blinds",        "MoneyUnit": 0      },      "Limit": {        "OptionType": "NoLimit"      }    }  }}')
    assert_command('{  "CommandName": "JoinTableCommand",  "TableId": 42}')
    assert_command('{  "CommandName": "JoinTableResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Command": {    "CommandName": "JoinTableCommand",    "TableId": 42  }}')
    assert_command('{  "CommandName": "LeaveTableCommand",  "TableId": 42}')
    assert_command('{  "CommandName": "ListTableCommand",  "LobbyTypes": [    "QuickMode",    "RegisteredMode"  ]}')
    assert_command('{  "CommandName": "ListTableResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Tables": [    {      "IdTable": 42,      "NbPlayers": 6,      "PossibleAction": "Join",      "Params": {        "TableName": "Bikini Bottom",        "GameType": "Holdem",        "Variant": "Texas Hold\'em",        "MinPlayersToStart": 2,        "MaxPlayers": 10,        "WaitingTimes": {          "AfterPlayerAction": 500,          "AfterBoardDealed": 500,          "AfterPotWon": 2500        },        "MoneyUnit": 10,        "Lobby": {          "OptionType": "QuickMode",          "StartingAmount": 1500        },        "Blind": {          "OptionType": "Antes",          "MoneyUnit": 10        },        "Limit": {          "OptionType": "NoLimit"        }      }    },    {      "IdTable": 84,      "NbPlayers": 3,      "PossibleAction": "Leave",      "Params": {        "TableName": "Pokemon World",        "GameType": "Holdem",        "Variant": "Texas Hold\'em",        "MinPlayersToStart": 2,        "MaxPlayers": 10,        "WaitingTimes": {          "AfterPlayerAction": 500,          "AfterBoardDealed": 500,          "AfterPotWon": 2500        },        "MoneyUnit": 10,        "Lobby": {          "OptionType": "QuickMode",          "StartingAmount": 1500        },        "Blind": {          "OptionType": "Blinds",          "MoneyUnit": 10        },        "Limit": {          "OptionType": "NoLimit"        }      }    }  ],  "Command": {    "CommandName": "ListTableCommand",    "LobbyTypes": [      "QuickMode",      "RegisteredMode"    ]  }}')
    assert_command('{  "CommandName": "CheckCompatibilityCommand",  "ImplementedProtocolVersion": "2.0.0"}')
    assert_command('{  "CommandName": "CheckCompatibilityResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "ImplementedProtocolVersion": "2.0.0",  "SupportedLobbyTypes": [    "QuickMode",    "RegisteredMode"  ],  "Rules": [    {      "GameType": "Holdem",      "Name": "Texas Hold\'em",      "MinPlayers": 2,      "MaxPlayers": 10,      "AvailableLimits": [        "NoLimit"      ],      "DefaultLimit": "NoLimit",      "AvailableBlinds": [        "Blinds",        "Antes",        "None"      ],      "DefaultBlind": "Blinds",      "CanConfigWaitingTime": true,      "AvailableLobbys": [        "QuickMode",        "RegisteredMode"      ]    }  ],  "Command": {    "CommandName": "CheckCompatibilityCommand",    "ImplementedProtocolVersion": "2.0.0"  }}')
    assert_command('{  "CommandName": "AuthenticateUserCommand",  "Username": "ericmas001",  "Password": "0nc3Up0nAT1m3"}')
    assert_command('{  "CommandName": "AuthenticateUserResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Command": {    "CommandName": "AuthenticateUserCommand",    "Username": "ericmas001",    "Password": "0nc3Up0nAT1m3"  }}')
    assert_command('{  "CommandName": "CheckDisplayExistCommand",  "DisplayName": "Sponge Bob"}')
    assert_command('{  "CommandName": "CheckDisplayExistResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Exist": true,  "Command": {    "CommandName": "CheckDisplayExistCommand",    "DisplayName": "Sponge Bob"  }}')
    assert_command('{  "CommandName": "CheckUserExistCommand",  "Username": "ericmas001"}')
    assert_command('{  "CommandName": "CheckUserExistResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Exist": true,  "Command": {  "CommandName": "CheckUserExistCommand",  "Username": "ericmas001"}}')
    assert_command('{  "CommandName": "CreateUserCommand",  "Username": "ericmas001",  "Password": "0nc3Up0nAT1m3",  "Email": "ericmas001@hotmail.com",  "DisplayName": "Sponge Bob"}')
    assert_command('{  "CommandName": "CreateUserResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Command": {    "CommandName": "CreateUserCommand",    "Username": "ericmas001",    "Password": "0nc3Up0nAT1m3",    "Email": "ericmas001@hotmail.com",    "DisplayName": "Sponge Bob"  }}')
    assert_command('{  "CommandName": "GetUserCommand"}')
    assert_command('{  "CommandName": "GetUserResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Email": "ericmas001@hotmail.com",  "DisplayName": "Sponge Bob",  "Money": 42000.42,  "Command": {    "CommandName": "GetUserCommand"  }}')
    assert_command('{  "CommandName": "BetTurnEndedCommand",  "TableId": 42,  "Round": "Flop",  "PotsAmounts": [    4200,    420  ]}')
    assert_command('{  "CommandName": "BetTurnStartedCommand",  "TableId": 42,  "Round": "Flop",  "BettingRoundId": 1,  "Cards": [    "2s",    "Kh",    "5d"  ]}')
    assert_command('{  "CommandName": "DiscardRoundEndedCommand",  "TableId": 42,  "CardsDiscarded": [    {      "NoSeat": 7,      "NbCardsDiscarded": 3    }  ]}')
    assert_command('{  "CommandName": "DiscardRoundStartedCommand",  "TableId": 42,  "MinimumCardsToDiscard": 0,  "MaximumCardsToDiscard": 5}')
    assert_command('{  "CommandName": "GameEndedCommand",  "TableId": 42}')
    assert_command('{  "CommandName": "GameStartedCommand",  "TableId": 42,  "NeededBlindAmount": 10}')
    assert_command('{  "CommandName": "PlayerHoleCardsChangedCommand",  "TableId": 42,  "NoSeat": 7,  "Cards": [    "4h",    "Qs"  ],  "PlayerState": "Playing"}')
    assert_command('{  "CommandName": "PlayerJoinedCommand",  "TableId": 42,  "PlayerName": "Sponge Bob"}')
    assert_command('{  "CommandName": "PlayerLeftCommand",  "TableId": 42,  "PlayerName": "Sponge Bob"}')
    assert_command('{  "CommandName": "PlayerTurnBeganCommand",  "TableId": 42,  "NoSeat": 7, "AmountNeeded":21, "MinimumRaiseAmount": 42}')
    assert_command('{  "CommandName": "PlayerTurnEndedCommand",  "TableId": 42,  "NoSeat": 7,  "TotalPlayedMoneyAmount": 420,  "TotalSafeMoneyAmount": 4200,  "TotalPot": 42000,  "ActionTakenType": "Call",  "ActionTakenAmount": 42,  "PlayerState": "Playing"}')
    assert_command('{  "CommandName": "PlayerWonPotCommand",  "TableId": 42,  "NoSeat": 7,  "PotId": 0,  "WonAmount": 420,  "TotalPotAmount": 1000,  "TotalPlayerMoney": 4200,  "WinningCards": [    "5s",    "5c",    "5d",    "Ad",    "Ks"  ],  "WinningHand": "ThreeOfAKind"}')
    assert_command('{  "CommandName": "SeatUpdatedCommand",  "TableId": 42,  "Seat": {    "NoSeat": 7,    "Player": {      "NoSeat": 7,      "Name": "SpongeBob",      "MoneySafeAmnt": 1000,      "MoneyBetAmnt": 42,      "HoleCards": [        "2s",        "Ah"      ],      "State": "Playing",      "IsShowingCards": true    },    "SeatAttributes": [      "CurrentPlayer",      "BigBlind"    ]  }}')
    assert_command('{  "CommandName": "TableClosedCommand",  "TableId": 42}')
    assert_command('{  "CommandName": "TableInfoCommand",  "TableId": 42,  "Params": {    "TableName": "Bikini Bottom",    "GameType": "Holdem",    "Variant": "Texas Hold\'em",    "MinPlayersToStart": 2,    "MaxPlayers": 10,    "WaitingTimes": {      "AfterPlayerAction": 500,      "AfterBoardDealed": 500,      "AfterPotWon": 2500    },    "MoneyUnit": 10,    "Lobby": {      "OptionType": "QuickMode",      "StartingAmount": 1500    },    "Blind": {      "OptionType": "Blinds",      "MoneyUnit": 0    },    "Limit": {      "OptionType": "NoLimit"    }  },  "TotalPotAmount": 42000,  "PotsAmount": [    4200,    420  ],  "BoardCards": [    "2s",    "Kh",    "5d"  ],  "Seats": [    {      "NoSeat": 7,      "Player": {        "NoSeat": 7,        "Name": "SpongeBob",        "MoneySafeAmnt": 1000,        "MoneyBetAmnt": 42,        "HoleCards": [          "2s",          "Ah"        ],        "State": "Playing",        "IsShowingCards": true      },      "SeatAttributes": [        "CurrentPlayer",        "BigBlind"      ]    }  ],  "GameHasStarted": true}')
    assert_command('{  "CommandName": "PlayerDiscardActionCommand",  "TableId": 42,  "CardsDiscarded": [    "2s",    "7c",    "Kh"  ]}')
    assert_command('{  "CommandName": "PlayerPlayMoneyCommand",  "TableId": 42,  "AmountPlayed": 42}')
    assert_command('{  "CommandName": "PlayerSitInCommand",  "TableId": 42,  "NoSeat": 7,  "MoneyAmount": 4200}')
    assert_command('{  "CommandName": "PlayerSitInResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "NoSeat": 7,  "TableId": 42,  "Command": {    "CommandName": "PlayerSitInCommand",    "TableId": 42,    "NoSeat": 7,    "MoneyAmount": 4200  }}')
    assert_command('{  "CommandName": "PlayerSitOutCommand",  "TableId": 42}')
    assert_command('{  "CommandName": "PlayerSitOutResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "TableId": 42,  "Command": {    "CommandName": "PlayerSitOutCommand",    "TableId": 42  }}')

if __name__ == "__main__":
    run_module_suite()
