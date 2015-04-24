# Lobby : ListTable

BluffinMuffin.Protocol.Lobby.ListTableCommand

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
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyTypeEnum[]",
      "properties": {
        "IsFixedSize": {
          "type": "bool"
        },
        "IsReadOnly": {
          "type": "bool"
        },
        "IsSynchronized": {
          "type": "bool"
        },
        "Length": {
          "type": "int"
        },
        "LongLength": {
          "type": "long"
        },
        "Rank": {
          "type": "int"
        },
        "SyncRoot": {
          "type": "System.Object",
          "properties": {}
        }
      }
    }
  }
}
```

### Example

```json
{
  "CommandName": "ListTableCommand",
  "LobbyTypes": null
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
    "Tables": {
      "type": "System.Collections.Generic.List`1[[BluffinMuffin.Protocol.DataTypes.TupleTable, BluffinMuffin.Protocol.DataTypes, Version=0.5.0.0, Culture=neutral, PublicKeyToken=null]]",
      "properties": {
        "Capacity": {
          "type": "int"
        },
        "Count": {
          "type": "int"
        },
        "Item": {
          "type": "BluffinMuffin.Protocol.DataTypes.TupleTable",
          "properties": {
            "BigBlind": {
              "type": "int"
            },
            "IdTable": {
              "type": "int"
            },
            "NbPlayers": {
              "type": "int"
            },
            "Params": {
              "type": "BluffinMuffin.Protocol.DataTypes.TableParams",
              "properties": {
                "GameType": {
                  "description": "The type of poker",
                  "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameTypeEnum",
                  "enum": [
                    "Holdem"
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
                  "type": "BluffinMuffin.Protocol.DataTypes.BlindOptions",
                  "properties": {
                    "MoneyUnit": {
                      "description": "The Money unit. Should always be equal to the moneyUnit of the table.",
                      "type": "int"
                    },
                    "OptionType": {
                      "description": "The type of blinds used for the table",
                      "type": "BluffinMuffin.Protocol.DataTypes.Enums.BlindTypeEnum",
                      "enum": [
                        "Antes",
                        "Blinds",
                        "None"
                      ]
                    }
                  }
                },
                "Limit": {
                  "description": "The type of blinds the table uses (NoLimit, PotLimit, FixedLimit) See 'BluffinMuffin.Protocol.DataTypes.LimitOptions' for more details",
                  "type": "BluffinMuffin.Protocol.DataTypes.LimitOptions",
                  "properties": {
                    "OptionType": {
                      "description": "The type of limit you want to apply on raises",
                      "type": "BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum",
                      "enum": [
                        "FixedLimit",
                        "NoLimit",
                        "PotLimit"
                      ]
                    }
                  }
                },
                "Lobby": {
                  "description": "The type of table it is (Training ? Career ?) See 'BluffinMuffin.Protocol.DataTypes.LobbyOptions' for more details",
                  "type": "BluffinMuffin.Protocol.DataTypes.LobbyOptions",
                  "properties": {
                    "OptionType": {
                      "description": "What type of lobby it is",
                      "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyTypeEnum",
                      "enum": [
                        "Career",
                        "Training"
                      ]
                    }
                  }
                }
              }
            },
            "PossibleAction": {
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyActionEnum",
              "enum": [
                "Join",
                "Leave",
                "None"
              ]
            }
          }
        }
      }
    },
    "Command": {
      "type": "BluffinMuffin.Protocol.Lobby.ListTableCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'ListTableCommand' to distinguish the command from others.",
          "type": "string"
        },
        "LobbyTypes": {
          "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyTypeEnum[]",
          "properties": {
            "IsFixedSize": {
              "type": "bool"
            },
            "IsReadOnly": {
              "type": "bool"
            },
            "IsSynchronized": {
              "type": "bool"
            },
            "Length": {
              "type": "int"
            },
            "LongLength": {
              "type": "long"
            },
            "Rank": {
              "type": "int"
            },
            "SyncRoot": {
              "type": "System.Object",
              "properties": {}
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
  "CommandName": "ListTableResponse",
  "Tables": [],
  "Command": {
    "CommandName": "ListTableCommand",
    "LobbyTypes": null
  }
}
```

