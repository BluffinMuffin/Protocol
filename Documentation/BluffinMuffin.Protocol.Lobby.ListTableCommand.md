# Lobby : ListTable

To list tables, you have to send a **List Table** command with the types of lobbys you are interested in.

The list of active tables will be sent back

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/BluffinMuffin.Protocol.Lobby.ListTableCommand.png" alt="Sequence Diagram"></p>

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/BluffinMuffin.Protocol.Lobby.ListTableCommand.png" alt="Activity Diagram"></p>

## ListTableCommand

### Command Schema

```json
{
  "title": "Schema for ListTableCommand",
  "type": "BluffinMuffin.Protocol.Lobby.ListTableCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'ListTableCommand' to distinguish the command from others.",
      "type": "string"
    },
    "LobbyTypes": {
      "description": "All the different types of lobby we want to see tables of.",
      "type": "array",
      "items": {
        "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyTypeEnum",
        "enum": [
          "QuickMode",
          "RegisteredMode"
        ]
      }
    }
  }
}
```

### Example

```json
{
  "CommandName": "ListTableCommand",
  "LobbyTypes": [
    "QuickMode",
    "RegisteredMode"
  ]
}
```

## ListTableResponse

### Command Schema

```json
{
  "title": "Schema for ListTableResponse",
  "type": "BluffinMuffin.Protocol.Lobby.ListTableResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'ListTableResponse' to distinguish the command from others.",
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
    "Tables": {
      "description": "All the active tables on the server",
      "type": "array",
      "items": {
        "type": "BluffinMuffin.Protocol.DataTypes.TupleTable",
        "properties": {
          "IdTable": {
            "description": "The id of the table",
            "type": "int"
          },
          "NbPlayers": {
            "description": "The nb of players currently sitting at the table",
            "type": "int"
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
          "PossibleAction": {
            "description": "The action available to you for this table (Nothing, Join, Leave)",
            "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyActionEnum",
            "enum": [
              "None",
              "Join",
              "Leave"
            ]
          }
        }
      }
    },
    "Command": {
      "description": "The command who initiated this response",
      "type": "BluffinMuffin.Protocol.Lobby.ListTableCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'ListTableCommand' to distinguish the command from others.",
          "type": "string"
        },
        "LobbyTypes": {
          "description": "All the different types of lobby we want to see tables of.",
          "type": "array",
          "items": {
            "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyTypeEnum",
            "enum": [
              "QuickMode",
              "RegisteredMode"
            ]
          }
        }
      }
    }
  }
}
```

### Example

```json
{
  "CommandName": "ListTableResponse",
  "Success": true,
  "MessageId": "None",
  "Message": "",
  "Tables": [
    {
      "IdTable": 42,
      "NbPlayers": 6,
      "PossibleAction": "Join",
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
      }
    }
  ],
  "Command": {
    "CommandName": "ListTableCommand",
    "LobbyTypes": [
      "QuickMode",
      "RegisteredMode"
    ]
  }
}
```

