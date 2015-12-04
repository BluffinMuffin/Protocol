# Lobby : JoinTable

To join a table, you have to send a **Join Table ** command with the id of the table you want to join.

The success of the operation will be sent back

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/BluffinMuffin.Protocol.Lobby.JoinTableCommand.png" alt="Sequence Diagram"></p>

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/BluffinMuffin.Protocol.Lobby.JoinTableCommand.png" alt="Activity Diagram"></p>

## JoinTableCommand

### Command Schema

```json
{
  "title": "Schema for JoinTableCommand",
  "type": "BluffinMuffin.Protocol.Lobby.JoinTableCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'JoinTableCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table to join",
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "JoinTableCommand",
  "TableId": 42
}
```

## JoinTableResponse

### Command Schema

```json
{
  "title": "Schema for JoinTableResponse",
  "type": "BluffinMuffin.Protocol.Lobby.JoinTableResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'JoinTableResponse' to distinguish the command from others.",
      "type": "string"
    },
    "Success": {
      "description": "True if the command was a success",
      "type": "bool"
    },
    "MessageId": {
      "description": "The Id of the message. None if no message",
      "type": "BluffinMuffin.Protocol.Enums.BluffinMessageId",
      "enum": [
        "None",
        "SpecificServerMessage",
        "WrongTableState",
        "NameAlreadyUsed",
        "UsernameAlreadyUsed",
        "UsernameNotFound",
        "InvalidPassword",
        "InvalidEmail",
        "SeatChanged",
        "NoMoreSeats",
        "NotAuthenticated",
        "WrongLobbyType",
        "NotSupported"
      ]
    },
    "Message": {
      "description": "The message. Empty if no messages",
      "type": "string"
    },
    "BoardCards": {
      "description": "All the card ids currently visible on the board (Preflop: empty, flop: 3 cars, turn: 4 cards, river: 5 cards)",
      "type": "array",
      "items": {
        "type": "string"
      }
    },
    "GameHasStarted": {
      "description": "Informs the client if the game is currently in the playing state, or not.",
      "type": "bool"
    },
    "Params": {
      "description": "Parameters of the poker table",
      "type": "BluffinMuffin.Protocol.DataTypes.TableParams",
      "properties": {
        "Arguments": {
          "description": "Some more parameters. Those parameters are specific to a server and are free-format. Generally, this field would be blank.",
          "type": "string"
        },
        "Blind": {
          "description": "The type of blinds the table uses (none, blinds, antes)",
          "type": "BluffinMuffin.Protocol.DataTypes.Enums.BlindTypeEnum",
          "enum": [
            "Blinds",
            "Antes",
            "None"
          ]
        },
        "GameSize": {
          "description": "The size of the table. It represents the small bet and the big blind. Big bet will be double the GameSize, small blind is half the GameSize, and Ante is 1/10 the GameSize",
          "type": "int"
        },
        "Limit": {
          "description": "The type of limit the table uses (NoLimit, PotLimit, FixedLimit)",
          "type": "BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum",
          "enum": [
            "NoLimit",
            "FixedLimit",
            "PotLimit"
          ]
        },
        "MaxPlayers": {
          "description": "The maximum number of players. (Between 2 and MaxPlayers of the GameInfo, and must be >= MinPlayersToStart)",
          "type": "int"
        },
        "MinPlayersToStart": {
          "description": "The minimum seated players needed to start the game. (Between 2 and 10)",
          "type": "int"
        },
        "TableName": {
          "description": "The name of the table",
          "type": "string"
        },
        "Variant": {
          "description": "The variant of the GameType",
          "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameSubTypeEnum",
          "enum": [
            "TexasHoldem",
            "OmahaHoldem",
            "Pineapple",
            "CrazyPineapple",
            "LazyPineapple",
            "ThreeCardsHoldem",
            "IrishPoker",
            "SpanishPoker",
            "ManilaPoker",
            "FiveCardsStud",
            "SevenCardsStud",
            "FiveCardsDraw"
          ]
        },
        "WaitingTimes": {
          "description": "The waiting times (At different stage of the game, the server will wait before continuing to making it feel real !)",
          "type": "BluffinMuffin.Protocol.DataTypes.ConfigurableWaitingTimes",
          "properties": {
            "AfterBoardDealed": {
              "description": "Amount of miliseconds (ms) to wait after cards are dealed",
              "type": "int"
            },
            "AfterPlayerAction": {
              "description": "Amount of miliseconds (ms) to wait after a player do something.",
              "type": "int"
            },
            "AfterPotWon": {
              "description": "Amount of miliseconds (ms) to wait after pot is won",
              "type": "int"
            }
          }
        },
        "Lobby": {
          "description": "The type of table it is (QuickMode ? RegisteredMode ?) See 'BluffinMuffin.Protocol.DataTypes.Options.GameTypeOptions' for more details",
          "type": "BluffinMuffin.Protocol.DataTypes.Options.LobbyOptions",
          "properties": {
            "OptionType": {
              "description": "What type of lobby it is",
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyTypeEnum",
              "enum": [
                "QuickMode",
                "RegisteredMode"
              ]
            }
          }
        },
        "Options": {
          "description": "The type of table it is (QuickMode ? RegisteredMode ?) See 'BluffinMuffin.Protocol.DataTypes.Options.LobbyOptions' for more details",
          "type": "BluffinMuffin.Protocol.DataTypes.Options.GameTypeOptions",
          "properties": {
            "OptionType": {
              "description": "The type of game you want to play",
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameTypeEnum",
              "enum": [
                "CommunityCardsPoker",
                "StudPoker",
                "DrawPoker"
              ]
            }
          }
        }
      }
    },
    "PotsAmount": {
      "description": "All the pots on the table. Usually only one, but can have more if some players are all-in.",
      "type": "array",
      "items": {
        "type": "int"
      }
    },
    "Seats": {
      "description": "The information about every seats around the table",
      "type": "array",
      "items": {
        "type": "BluffinMuffin.Protocol.DataTypes.SeatInfo",
        "properties": {
          "NoSeat": {
            "description": "The id of the current seat",
            "type": "int"
          },
          "Player": {
            "description": "The information of the player sitting in this seat. If null, there is nobody.",
            "type": "BluffinMuffin.Protocol.DataTypes.PlayerInfo",
            "properties": {
              "FaceDownCards": {
                "description": "The cards in hand that are currently facing down (hidden to other players).",
                "type": "array",
                "items": {
                  "type": "string"
                }
              },
              "FaceUpCards": {
                "description": "The cards in hand that are currently facing up (visible to other players).",
                "type": "array",
                "items": {
                  "type": "string"
                }
              },
              "MoneyBetAmnt": {
                "description": "Current Money Amount of the player that he played this round",
                "type": "int"
              },
              "MoneySafeAmnt": {
                "description": "Current Money Amount of the player that he isn't playing with",
                "type": "int"
              },
              "Name": {
                "description": "The name of the player",
                "type": "string"
              },
              "NoSeat": {
                "description": "The seat used by the player",
                "type": "int"
              },
              "State": {
                "description": "Current state of the player",
                "type": "BluffinMuffin.Protocol.DataTypes.Enums.PlayerStateEnum",
                "enum": [
                  "None",
                  "Joined",
                  "SitIn",
                  "AllIn",
                  "Playing"
                ]
              }
            }
          },
          "SeatAttributes": {
            "description": "The attributes of the seat",
            "type": "array",
            "items": {
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.SeatAttributeEnum",
              "enum": [
                "Dealer",
                "SmallBlind",
                "BigBlind",
                "CurrentPlayer",
                "FirstTalker"
              ]
            }
          }
        }
      }
    },
    "TotalPotAmount": {
      "description": "The total amount of money currently played in this game. This include the money in the center, and the money played in front of each player.",
      "type": "int"
    },
    "Command": {
      "description": "The command who initiated this response",
      "type": "BluffinMuffin.Protocol.Lobby.JoinTableCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'JoinTableCommand' to distinguish the command from others.",
          "type": "string"
        },
        "TableId": {
          "description": "The id of the table to join",
          "type": "int"
        }
      }
    }
  }
}
```

### Example

```json
{
  "CommandName": "JoinTableResponse",
  "Success": true,
  "MessageId": "None",
  "Message": "",
  "Params": {
    "TableName": "Bikini Bottom",
    "Variant": "TexasHoldem",
    "MinPlayersToStart": 2,
    "MaxPlayers": 10,
    "WaitingTimes": {
      "AfterPlayerAction": 500,
      "AfterBoardDealed": 500,
      "AfterPotWon": 2500
    },
    "GameSize": 10,
    "Arguments": "",
    "Blind": "Blinds",
    "Limit": "NoLimit",
    "Options": {
      "OptionType": "CommunityCardsPoker"
    },
    "Lobby": {
      "OptionType": "QuickMode",
      "StartingAmount": 1500
    }
  },
  "TotalPotAmount": 42000,
  "PotsAmount": [
    4200,
    420
  ],
  "BoardCards": [
    "2s",
    "Kh",
    "5d"
  ],
  "Seats": [
    {
      "NoSeat": 7,
      "Player": {
        "NoSeat": 7,
        "Name": "SpongeBob",
        "MoneySafeAmnt": 1000,
        "MoneyBetAmnt": 42,
        "FaceUpCards": [
          "2s",
          "Ah"
        ],
        "FaceDownCards": [
          "??",
          "??"
        ],
        "State": "Playing"
      },
      "SeatAttributes": [
        "CurrentPlayer",
        "BigBlind"
      ]
    }
  ],
  "GameHasStarted": true,
  "Command": {
    "CommandName": "JoinTableCommand",
    "TableId": 42
  }
}
```

