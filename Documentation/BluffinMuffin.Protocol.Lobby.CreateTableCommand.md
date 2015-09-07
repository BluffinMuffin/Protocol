# Lobby : CreateTable

To create a new table, you have to send a **Create Table** command with all the parameters of the poker table.

If successful, the id of the table will be received. If not, server will send "-1".

More information on ...

* [LobbyOptions](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.DataTypes.LobbyOptions.md)

* [BlindOptions](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.DataTypes.BlindOptions.md)

* [LimitOptions](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.DataTypes.LimitOptions.md)

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/BluffinMuffin.Protocol.Lobby.CreateTableCommand.png" alt="Sequence Diagram"></p>

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/BluffinMuffin.Protocol.Lobby.CreateTableCommand.png" alt="Activity Diagram"></p>

## CreateTableCommand

### Command Schema

```json
{
  "title": "Schema for CreateTableCommand",
  "type": "BluffinMuffin.Protocol.Lobby.CreateTableCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CreateTableCommand' to distinguish the command from others.",
      "type": "string"
    },
    "Params": {
      "description": "Parameters of the poker table",
      "type": "BluffinMuffin.Protocol.DataTypes.TableParams",
      "properties": {
        "GameType": {
          "description": "The type of poker",
          "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameTypeEnum",
          "enum": [
            "DrawPoker",
            "StudPoker",
            "CommunityCardsPoker"
          ]
        },
        "MaxPlayers": {
          "description": "The maximum number of players. (Between 2 and 10, and must be >= MinPlayersToStart)",
          "type": "int"
        },
        "MinPlayersToStart": {
          "description": "The minimum seated players needed to start the game. (Between 2 and 10)",
          "type": "int"
        },
        "MoneyUnit": {
          "description": "The unit used by the table. This unit is usually the big blind, the minimum raise, etc.",
          "type": "int"
        },
        "TableName": {
          "description": "The name of the table",
          "type": "string"
        },
        "Variant": {
          "description": "The variant of the GameType",
          "type": "string"
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
        "Blind": {
          "description": "The type of blinds the table uses (none, blinds, antes) See 'BluffinMuffin.Protocol.DataTypes.BlindOptions' for more details",
          "type": "BluffinMuffin.Protocol.DataTypes.Options.BlindOptions",
          "properties": {
            "MoneyUnit": {
              "description": "The Money unit. Should always be equal to the moneyUnit of the table.",
              "type": "int"
            },
            "OptionType": {
              "description": "The type of blinds used for the table",
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.BlindTypeEnum",
              "enum": [
                "Blinds",
                "Antes",
                "None"
              ]
            }
          }
        },
        "Limit": {
          "description": "The type of limit the table uses (NoLimit, PotLimit, FixedLimit) See 'BluffinMuffin.Protocol.DataTypes.LimitOptions' for more details",
          "type": "BluffinMuffin.Protocol.DataTypes.Options.LimitOptions",
          "properties": {
            "OptionType": {
              "description": "The type of limit you want to apply on raises",
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum",
              "enum": [
                "NoLimit",
                "FixedLimit",
                "PotLimit"
              ]
            }
          }
        },
        "Lobby": {
          "description": "The type of table it is (QuickMode ? RegisteredMode ?) See 'BluffinMuffin.Protocol.DataTypes.LobbyOptions' for more details",
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
        }
      }
    }
  }
}
```

### Example

```json
{
  "CommandName": "CreateTableCommand",
  "Params": {
    "TableName": "Bikini Bottom",
    "GameType": "CommunityCardsPoker",
    "Variant": "Texas Hold'em",
    "MinPlayersToStart": 2,
    "MaxPlayers": 10,
    "WaitingTimes": {
      "AfterPlayerAction": 500,
      "AfterBoardDealed": 500,
      "AfterPotWon": 2500
    },
    "MoneyUnit": 10,
    "Lobby": {
      "OptionType": "QuickMode",
      "StartingAmount": 1500
    },
    "Blind": {
      "OptionType": "Blinds",
      "MoneyUnit": 10
    },
    "Limit": {
      "OptionType": "NoLimit"
    }
  }
}
```

## CreateTableResponse

### Command Schema

```json
{
  "title": "Schema for CreateTableResponse",
  "type": "BluffinMuffin.Protocol.Lobby.CreateTableResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CreateTableResponse' to distinguish the command from others.",
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
    "IdTable": {
      "description": "The id of the table that was created",
      "type": "int"
    },
    "Command": {
      "description": "The command who initiated this response",
      "type": "BluffinMuffin.Protocol.Lobby.CreateTableCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'CreateTableCommand' to distinguish the command from others.",
          "type": "string"
        },
        "Params": {
          "description": "Parameters of the poker table",
          "type": "BluffinMuffin.Protocol.DataTypes.TableParams",
          "properties": {
            "GameType": {
              "description": "The type of poker",
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameTypeEnum",
              "enum": [
                "DrawPoker",
                "StudPoker",
                "CommunityCardsPoker"
              ]
            },
            "MaxPlayers": {
              "description": "The maximum number of players. (Between 2 and 10, and must be >= MinPlayersToStart)",
              "type": "int"
            },
            "MinPlayersToStart": {
              "description": "The minimum seated players needed to start the game. (Between 2 and 10)",
              "type": "int"
            },
            "MoneyUnit": {
              "description": "The unit used by the table. This unit is usually the big blind, the minimum raise, etc.",
              "type": "int"
            },
            "TableName": {
              "description": "The name of the table",
              "type": "string"
            },
            "Variant": {
              "description": "The variant of the GameType",
              "type": "string"
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
            "Blind": {
              "description": "The type of blinds the table uses (none, blinds, antes) See 'BluffinMuffin.Protocol.DataTypes.BlindOptions' for more details",
              "type": "BluffinMuffin.Protocol.DataTypes.Options.BlindOptions",
              "properties": {
                "MoneyUnit": {
                  "description": "The Money unit. Should always be equal to the moneyUnit of the table.",
                  "type": "int"
                },
                "OptionType": {
                  "description": "The type of blinds used for the table",
                  "type": "BluffinMuffin.Protocol.DataTypes.Enums.BlindTypeEnum",
                  "enum": [
                    "Blinds",
                    "Antes",
                    "None"
                  ]
                }
              }
            },
            "Limit": {
              "description": "The type of limit the table uses (NoLimit, PotLimit, FixedLimit) See 'BluffinMuffin.Protocol.DataTypes.LimitOptions' for more details",
              "type": "BluffinMuffin.Protocol.DataTypes.Options.LimitOptions",
              "properties": {
                "OptionType": {
                  "description": "The type of limit you want to apply on raises",
                  "type": "BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum",
                  "enum": [
                    "NoLimit",
                    "FixedLimit",
                    "PotLimit"
                  ]
                }
              }
            },
            "Lobby": {
              "description": "The type of table it is (QuickMode ? RegisteredMode ?) See 'BluffinMuffin.Protocol.DataTypes.LobbyOptions' for more details",
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
            }
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
  "CommandName": "CreateTableResponse",
  "Success": true,
  "MessageId": "None",
  "Message": "",
  "IdTable": 42,
  "Command": {
    "CommandName": "CreateTableCommand",
    "Params": {
      "TableName": "Bikini Bottom",
      "GameType": "CommunityCardsPoker",
      "Variant": "Texas Hold'em",
      "MinPlayersToStart": 2,
      "MaxPlayers": 10,
      "WaitingTimes": {
        "AfterPlayerAction": 500,
        "AfterBoardDealed": 500,
        "AfterPotWon": 2500
      },
      "MoneyUnit": 10,
      "Lobby": {
        "OptionType": "QuickMode",
        "StartingAmount": 1500
      },
      "Blind": {
        "OptionType": "Blinds",
        "MoneyUnit": 10
      },
      "Limit": {
        "OptionType": "NoLimit"
      }
    }
  }
}
```

