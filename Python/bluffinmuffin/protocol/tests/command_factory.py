import json

from bluffinmuffin.protocol import *
from bluffinmuffin.protocol.game import *
from bluffinmuffin.protocol.lobby import *
from bluffinmuffin.protocol.lobby.quick_mode import *
from bluffinmuffin.protocol.lobby.registered_mode import *

from bluffinmuffin.protocol.tests.datatypes_factory import *


def disconnect_command_json():
    return '{  "CommandName": "DisconnectCommand"}'


def disconnect_command_obj():
    return DisconnectCommand()


def identify_command_json():
    return '{  "CommandName": "IdentifyCommand",  "Name": "SpongeBob"}'


def identify_command_obj():
    return IdentifyCommand("SpongeBob")


def identify_response_json():
    return '{  "CommandName": "IdentifyResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Command": {    "CommandName": "IdentifyCommand",    "Name": "SpongeBob"  }}'


def identify_response_obj():
    return IdentifyResponse(True, BluffinMessageIdEnum.Nothing, '', json.loads(identify_command_obj().encode()))


def create_table_command_json():
    return '{  "CommandName": "CreateTableCommand",  "Params": {    "TableName": "Bikini Bottom",    "Variant": "TexasHoldem",    "MinPlayersToStart": 2,    "MaxPlayers": 10,    "WaitingTimes": {      "AfterPlayerAction": 500,      "AfterBoardDealed": 500,      "AfterPotWon": 2500    },    "GameSize": 10,    "Arguments": "",    "Blind": "Blinds",    "Limit": "NoLimit",    "Options": {      "OptionType": "CommunityCardsPoker"    },    "Lobby": {      "OptionType": "QuickMode",      "StartingAmount": 1500    }  }}'


def create_table_command_obj():
    return CreateTableCommand(table_params1_obj())


def create_table_response_json():
    return '{  "CommandName": "CreateTableResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "IdTable": 42,  "Command": {  "CommandName": "CreateTableCommand",  "Params": {    "TableName": "Bikini Bottom",    "Variant": "TexasHoldem",    "MinPlayersToStart": 2,    "MaxPlayers": 10,    "WaitingTimes": {      "AfterPlayerAction": 500,      "AfterBoardDealed": 500,      "AfterPotWon": 2500    },    "GameSize": 10,    "Arguments": "",    "Blind": "Blinds",    "Limit": "NoLimit",    "Options": {      "OptionType": "CommunityCardsPoker"    },    "Lobby": {      "OptionType": "QuickMode",      "StartingAmount": 1500    }  }}}'


def create_table_response_obj():
    return CreateTableResponse(True, BluffinMessageIdEnum.Nothing, '', json.loads(create_table_command_obj().encode()),
                               42)


def join_table_command_json():
    return '{  "CommandName": "JoinTableCommand",  "TableId": 42}'


def join_table_command_obj():
    return JoinTableCommand(42)


def join_table_response_json():
    return '{  "CommandName": "JoinTableResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Params": {    "TableName": "Bikini Bottom",    "Variant": "TexasHoldem",    "MinPlayersToStart": 2,    "MaxPlayers": 10,    "WaitingTimes": {      "AfterPlayerAction": 500,      "AfterBoardDealed": 500,      "AfterPotWon": 2500    },    "GameSize": 10,    "Arguments": "",    "Blind": "Blinds",    "Limit": "NoLimit",    "Options": {      "OptionType": "CommunityCardsPoker"    },    "Lobby": {      "OptionType": "QuickMode",      "StartingAmount": 1500    }  },  "TotalPotAmount": 42000,  "PotsAmount": [    4200,    420  ],  "BoardCards": [    "2s",    "Kh",    "5d"  ],  "Seats": [    {      "NoSeat": 7,      "Player": {        "NoSeat": 7,        "Name": "SpongeBob",        "MoneySafeAmnt": 1000,        "MoneyBetAmnt": 42,        "FaceUpCards": [          "2s",          "Ah"        ],        "FaceDownCards": [          "??",          "??"        ],        "State": "Playing"      },      "SeatAttributes": [        "CurrentPlayer",        "BigBlind"      ]    },{"NoSeat": 8, "Player": null, "SeatAttributes": ["SmallBlind"]}  ],  "GameHasStarted": true,  "Command": {    "CommandName": "JoinTableCommand",    "TableId": 42  }}'


def join_table_response_obj():
    return JoinTableResponse(True, BluffinMessageIdEnum.Nothing, '', json.loads(join_table_command_obj().encode()), table_params1_obj(), 42000, [4200, 420], ["2s", "Kh", "5d"], [seat_info_obj(),empty_seat_info_obj()], True)


def leave_table_command_json():
    return '{  "CommandName": "LeaveTableCommand",  "TableId": 42}'


def leave_table_command_obj():
    return LeaveTableCommand(42)


def list_table_command_json():
    return '{  "CommandName": "ListTableCommand",  "LobbyTypes": [    "QuickMode",    "RegisteredMode"  ]}'


def list_table_command_obj():
    return ListTableCommand([LobbyTypeEnum.QuickMode, LobbyTypeEnum.RegisteredMode])


def list_table_response_json():
    return '{  "CommandName": "ListTableResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Tables": [    {      "IdTable": 42,      "NbPlayers": 6,      "PossibleAction": "Join",      "Params": {    "TableName": "Bikini Bottom",    "Variant": "TexasHoldem",    "MinPlayersToStart": 2,    "MaxPlayers": 10,    "WaitingTimes": {      "AfterPlayerAction": 500,      "AfterBoardDealed": 500,      "AfterPotWon": 2500    },    "GameSize": 10,    "Arguments": "",    "Blind": "Blinds",    "Limit": "NoLimit",    "Options": {      "OptionType": "CommunityCardsPoker"    },    "Lobby": {      "OptionType": "QuickMode",      "StartingAmount": 1500    }  }    },    {      "IdTable": 84,      "NbPlayers": 3,      "PossibleAction": "Leave",      "Params": {    "TableName": "Pokemon World",    "Variant": "TexasHoldem",    "MinPlayersToStart": 2,    "MaxPlayers": 10,    "WaitingTimes": {      "AfterPlayerAction": 500,      "AfterBoardDealed": 500,      "AfterPotWon": 2500    },    "GameSize": 10,    "Arguments": "",    "Blind": "Antes",    "Limit": "NoLimit",    "Options": {      "OptionType": "CommunityCardsPoker"    },    "Lobby": {      "OptionType": "QuickMode",      "StartingAmount": 1500    }  }    }  ],  "Command": {    "CommandName": "ListTableCommand",    "LobbyTypes": [      "QuickMode",      "RegisteredMode"    ]  }}'


def list_table_response_obj():
    return ListTableResponse(True, BluffinMessageIdEnum.Nothing, '', json.loads(list_table_command_obj().encode()),
                             [tuple_table1_obj(), tuple_table2_obj()])


def check_compatibility_command_json():
    return '{  "CommandName": "CheckCompatibilityCommand",  "ImplementedProtocolVersion": "2.0.0"}'


def check_compatibility_command_obj():
    return CheckCompatibilityCommand("2.0.0")


def check_compatibility_response_json():
    return '{  "CommandName": "CheckCompatibilityResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "ImplementedProtocolVersion": "2.0.0",  "SupportedLobbyTypes": [    "QuickMode",    "RegisteredMode"  ],  "AvailableGames": [    {      "GameType": "CommunityCardsPoker",      "AvailableVariants": [        "TexasHoldem",        "OmahaHoldem",        "CrazyPineapple"      ],      "AvailableLimits": [        "NoLimit",        "FixedLimit",        "PotLimit"      ],      "AvailableBlinds": [        "Blinds", "Antes", "None"      ],      "MinPlayers": 2,      "MaxPlayers": 10    }  ],  "Command": {    "CommandName": "CheckCompatibilityCommand",    "ImplementedProtocolVersion": "2.0.0"  }}'


def check_compatibility_response_obj():
    return CheckCompatibilityResponse(True, BluffinMessageIdEnum.Nothing, '',
                                      json.loads(check_compatibility_command_obj().encode()), "2.0.0",
                                      [LobbyTypeEnum.QuickMode, LobbyTypeEnum.RegisteredMode], [game_info_obj()])


def authenticate_user_command_json():
    return '{  "CommandName": "AuthenticateUserCommand",  "Username": "ericmas001",  "Password": "0nc3Up0nAT1m3"}'


def authenticate_user_command_obj():
    return AuthenticateUserCommand("ericmas001", "0nc3Up0nAT1m3")


def authenticate_user_response_json():
    return '{  "CommandName": "AuthenticateUserResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Command": {    "CommandName": "AuthenticateUserCommand",    "Username": "ericmas001",    "Password": "0nc3Up0nAT1m3"  }}'


def authenticate_user_response_obj():
    return AuthenticateUserResponse(True, BluffinMessageIdEnum.Nothing, '',
                                    json.loads(authenticate_user_command_obj().encode()))


def check_display_exist_command_json():
    return '{  "CommandName": "CheckDisplayExistCommand",  "DisplayName": "Sponge Bob"}'


def check_display_exist_command_obj():
    return CheckDisplayExistCommand("Sponge Bob")


def check_display_exist_response_json():
    return '{  "CommandName": "CheckDisplayExistResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Exist": true,  "Command": {    "CommandName": "CheckDisplayExistCommand",    "DisplayName": "Sponge Bob"  }}'


def check_display_exist_response_obj():
    return CheckDisplayExistResponse(True, BluffinMessageIdEnum.Nothing, '',
                                     json.loads(check_display_exist_command_obj().encode()), True)


def check_user_exist_command_json():
    return '{  "CommandName": "CheckUserExistCommand",  "Username": "ericmas001"}'


def check_user_exist_command_obj():
    return CheckUserExistCommand("ericmas001")


def check_user_exist_response_json():
    return '{  "CommandName": "CheckUserExistResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Exist": true,  "Command": {  "CommandName": "CheckUserExistCommand",  "Username": "ericmas001"}}'


def check_user_exist_response_obj():
    return CheckUserExistResponse(True, BluffinMessageIdEnum.Nothing, '',
                                  json.loads(check_user_exist_command_obj().encode()), True)


def create_user_command_json():
    return '{  "CommandName": "CreateUserCommand",  "Username": "ericmas001",  "Password": "0nc3Up0nAT1m3",  "Email": "ericmas001@hotmail.com",  "DisplayName": "Sponge Bob"}'


def create_user_command_obj():
    return CreateUserCommand("ericmas001", "0nc3Up0nAT1m3", "ericmas001@hotmail.com", "Sponge Bob")


def create_user_response_json():
    return '{  "CommandName": "CreateUserResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Command": {    "CommandName": "CreateUserCommand",    "Username": "ericmas001",    "Password": "0nc3Up0nAT1m3",    "Email": "ericmas001@hotmail.com",    "DisplayName": "Sponge Bob"  }}'


def create_user_response_obj():
    return CreateUserResponse(True, BluffinMessageIdEnum.Nothing, '', json.loads(create_user_command_obj().encode()))


def get_user_command_json():
    return '{  "CommandName": "GetUserCommand"}'


def get_user_command_obj():
    return GetUserCommand()


def get_user_response_json():
    return '{  "CommandName": "GetUserResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "Email": "ericmas001@hotmail.com",  "DisplayName": "Sponge Bob",  "Money": 42000.42,  "Command": {    "CommandName": "GetUserCommand"  }}'


def get_user_response_obj():
    return GetUserResponse(True, BluffinMessageIdEnum.Nothing, '', json.loads(get_user_command_obj().encode()),
                           "ericmas001@hotmail.com", "Sponge Bob", 42000.42)


def bet_turn_ended_command_json():
    return '{  "CommandName": "BetTurnEndedCommand",  "TableId": 42,  "PotsAmounts": [    4200,    420  ]}'


def bet_turn_ended_command_obj():
    return BetTurnEndedCommand(42, [4200, 420])


def bet_turn_started_command_json():
    return '{  "CommandName": "BetTurnStartedCommand",  "TableId": 42,  "BettingRoundId": 1,  "Cards": [    "2s",    "Kh",    "5d"  ],  "Seats": [    {      "NoSeat": 7,      "Player": {        "NoSeat": 7,        "Name": "SpongeBob",        "MoneySafeAmnt": 1000,        "MoneyBetAmnt": 42,        "FaceUpCards": [          "2s",          "Ah"        ],        "FaceDownCards": [          "??",          "??"        ],        "State": "Playing"      },      "SeatAttributes": [        "CurrentPlayer",        "BigBlind"      ]    },{"NoSeat": 8, "Player": null, "SeatAttributes": ["SmallBlind"]}  ]}'


def bet_turn_started_command_obj():
    return BetTurnStartedCommand(42, 1, ["2s", "Kh", "5d"], [seat_info_obj(),empty_seat_info_obj()])


def discard_round_ended_command_json():
    return '{  "CommandName": "DiscardRoundEndedCommand",  "TableId": 42,  "CardsDiscarded": [    {      "NoSeat": 7,      "NbCardsDiscarded": 3    }  ]}'


def discard_round_ended_command_obj():
    return DiscardRoundEndedCommand(42, [discard_info_obj()])


def discard_round_started_command_json():
    return '{  "CommandName": "DiscardRoundStartedCommand",  "TableId": 42,  "MinimumCardsToDiscard": 0,  "MaximumCardsToDiscard": 5}'


def discard_round_started_command_obj():
    return DiscardRoundStartedCommand(42, 0, 5)


def game_ended_command_json():
    return '{  "CommandName": "GameEndedCommand",  "TableId": 42}'


def game_ended_command_obj():
    return GameEndedCommand(42)


def game_started_command_json():
    return '{  "CommandName": "GameStartedCommand",  "TableId": 42,  "NeededBlindAmount": 10,  "Seats": [    {      "NoSeat": 7,      "Player": {        "NoSeat": 7,        "Name": "SpongeBob",        "MoneySafeAmnt": 1000,        "MoneyBetAmnt": 42,        "FaceUpCards": [          "2s",          "Ah"        ],        "FaceDownCards": [          "??",          "??"        ],        "State": "Playing"      },      "SeatAttributes": [        "CurrentPlayer",        "BigBlind"      ]    },{"NoSeat": 8, "Player": null, "SeatAttributes": ["SmallBlind"]}  ]}'


def game_started_command_obj():
    return GameStartedCommand(42, 10, [seat_info_obj(),empty_seat_info_obj()])


def player_hole_cards_changed_command_json():
    return '{  "CommandName": "PlayerHoleCardsChangedCommand",  "TableId": 42,  "NoSeat": 7,  "FaceUpCards": [    "2s",    "Ah"  ],  "FaceDownCards": [    "??",    "??"  ],  "PlayerState": "Playing"}'


def player_hole_cards_changed_command_obj():
    return PlayerHoleCardsChangedCommand(42, 7, ["2s", "Ah"], ["??", "??"], PlayerStateEnum.Playing)


def game_message_general_information_command_json():
    return '{  "CommandName": "GameMessageCommand",  "TableId": 42,  "Message": "General message sent by the server",  "Info": {    "OptionType": "GeneralInformation",    "Message": "General message sent by the server"  }}'


def game_message_general_information_command_obj():
    return GameMessageCommand(42, "General message sent by the server", GameMessageOptionGeneralInformation("General message sent by the server"))


def game_message_raising_capped_command_json():
    return '{  "CommandName": "GameMessageCommand",  "TableId": 42,  "Message": "Raising is capped",  "Info": {    "OptionType": "RaisingCapped"  }}'

def game_message_raising_capped_command_obj():
    return GameMessageCommand(42, "Raising is capped", GameMessageOptionsRaisingCapped())


def game_message_stud_bring_in_command_json():
    return '{  "CommandName": "GameMessageCommand",  "TableId": 42,  "Message": "SpongeBob is the bring-in",  "Info": {  "OptionType": "StudBringIn",  "Cards": [    "5s"  ],  "LowestHand": "HighCard",  "PlayerName": "SpongeBob"}}'

def game_message_stud_bring_in_command_obj():
    return GameMessageCommand(42, "SpongeBob is the bring-in", GameMessageOptionsStudBringIn("SpongeBob",PokerHandEnum.HighCard,["5s"]))


def game_message_stud_highest_hand_command_json():
    return '{  "CommandName": "GameMessageCommand",  "TableId": 42,  "Message": "SpongeBob has the highest hand",  "Info": {  "OptionType": "StudHighestHand",  "Cards": [    "As",    "Ah"  ],  "HighestHand": "OnePair",  "PlayerName": "SpongeBob"}}'

def game_message_stud_highest_hand_command_obj():
    return GameMessageCommand(42, "SpongeBob has the highest hand", GameMessageOptionsStudHighestHand("SpongeBob",PokerHandEnum.OnePair,["As","Ah"]))


def game_message_player_joined_command_json():
    return '{  "CommandName": "GameMessageCommand",  "TableId": 42,  "Message": "SpongeBob just joined the table",  "Info": {    "OptionType": "PlayerJoined",    "PlayerName": "SpongeBob"  }}'

def game_message_player_joined_command_obj():
    return GameMessageCommand(42, "SpongeBob just joined the table", GameMessageOptionPlayerJoined("SpongeBob"))


def game_message_player_left_command_json():
    return '{  "CommandName": "GameMessageCommand",  "TableId": 42,  "Message": "SpongeBob just left the table",  "Info": {  "OptionType": "PlayerLeft",  "PlayerName": "SpongeBob"}}'

def game_message_player_left_command_obj():
    return GameMessageCommand(42, "SpongeBob just left the table", GameMessageOptionPlayerLeft("SpongeBob"))

def player_turn_began_command_json():
    return '{  "CommandName": "PlayerTurnBeganCommand",  "TableId": 42,  "NoSeat": 7,  "AmountNeeded": 21,  "CanFold": true,  "MinimumRaiseAmount": 42,  "MaximumRaiseAmount": 4200}'


def player_turn_began_command_obj():
    return PlayerTurnBeganCommand(42, 7, 21, True, 42, 4200)


def player_turn_ended_command_json():
    return '{  "CommandName": "PlayerTurnEndedCommand",  "TableId": 42,  "NoSeat": 7,  "TotalPlayedMoneyAmount": 420,  "TotalSafeMoneyAmount": 4200,  "TotalPot": 42000,  "ActionTakenType": "Call",  "ActionTakenAmount": 42,  "PlayerState": "Playing"}'


def player_turn_ended_command_obj():
    return PlayerTurnEndedCommand(42, 7, 420, 4200, 42000, GameActionEnum.Call, 42, PlayerStateEnum.Playing)


def player_won_pot_command_json():
    return '{  "CommandName": "PlayerWonPotCommand",  "TableId": 42,  "NoSeat": 7,  "PotId": 0,  "WonAmount": 420,  "TotalPotAmount": 1000,  "TotalPlayerMoney": 4200,  "WinningCards": [    "5s",    "5c",    "5d",    "Ad",    "Ks"  ],  "WinningHand": "ThreeOfAKind"}'


def player_won_pot_command_obj():
    return PlayerWonPotCommand(42, 7, 0, 420, 1000, 4200, ["5s", "5c", "5d", "Ad", "Ks"], PokerHandEnum.ThreeOfAKind)


def seat_updated_command_json():
    return '{  "CommandName": "SeatUpdatedCommand",  "TableId": 42,  "Seat": {    "NoSeat": 7,    "Player": {      "NoSeat": 7,      "Name": "SpongeBob",      "MoneySafeAmnt": 1000,      "MoneyBetAmnt": 42,      "FaceUpCards": [        "2s",        "Ah"      ],      "FaceDownCards": [        "??",        "??"      ],      "State": "Playing"    },    "SeatAttributes": [      "CurrentPlayer",      "BigBlind"    ]  }}'


def seat_updated_command_obj():
    return SeatUpdatedCommand(42, seat_info_obj())


def table_closed_command_json():
    return '{  "CommandName": "TableClosedCommand",  "TableId": 42}'


def table_closed_command_obj():
    return TableClosedCommand(42)


def player_discard_action_command_json():
    return '{  "CommandName": "PlayerDiscardActionCommand",  "TableId": 42,  "CardsDiscarded": [    "2s",    "7c",    "Kh"  ]}'


def player_discard_action_command_obj():
    return PlayerDiscardActionCommand(42, ["2s", "7c", "Kh"])


def player_play_money_command_json():
    return '{  "CommandName": "PlayerPlayMoneyCommand",  "TableId": 42,  "AmountPlayed": 42}'


def player_play_money_command_obj():
    return PlayerPlayMoneyCommand(42, 42)


def player_sit_in_command_json():
    return '{  "CommandName": "PlayerSitInCommand",  "TableId": 42,  "NoSeat": 7,  "MoneyAmount": 4200}'


def player_sit_in_command_obj():
    return PlayerSitInCommand(42, 7, 4200)


def player_sit_in_response_json():
    return '{  "CommandName": "PlayerSitInResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "NoSeat": 7,  "TableId": 42,  "Command": {    "CommandName": "PlayerSitInCommand",    "TableId": 42,    "NoSeat": 7,    "MoneyAmount": 4200  }}'


def player_sit_in_response_obj():
    return PlayerSitInResponse(42, True, BluffinMessageIdEnum.Nothing, '',
                               json.loads(player_sit_in_command_obj().encode()), 7)


def player_sit_out_command_json():
    return '{  "CommandName": "PlayerSitOutCommand",  "TableId": 42}'


def player_sit_out_command_obj():
    return PlayerSitOutCommand(42)


def player_sit_out_response_json():
    return '{  "CommandName": "PlayerSitOutResponse",  "Success": true,  "MessageId": "None",  "Message": "",  "TableId": 42,  "Command": {    "CommandName": "PlayerSitOutCommand",    "TableId": 42  }}'


def player_sit_out_response_obj():
    return PlayerSitOutResponse(42, True, BluffinMessageIdEnum.Nothing, '',
                                json.loads(player_sit_out_command_obj().encode()))
