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

## ListTableCommand

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
                "Blind": {
                  "type": "BluffinMuffin.Protocol.DataTypes.BlindOptions",
                  "properties": {
                    "MoneyUnit": {
                      "type": "int"
                    },
                    "OptionType": {
                      "type": "BluffinMuffin.Protocol.DataTypes.Enums.BlindTypeEnum",
                      "enum": [
                        "Antes",
                        "Blinds",
                        "None"
                      ]
                    }
                  }
                },
                "GameType": {
                  "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameTypeEnum",
                  "enum": [
                    "Holdem"
                  ]
                },
                "Limit": {
                  "type": "BluffinMuffin.Protocol.DataTypes.LimitOptions",
                  "properties": {
                    "OptionType": {
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
                  "type": "BluffinMuffin.Protocol.DataTypes.LobbyOptions",
                  "properties": {
                    "MaximumAmountForBuyIn": {
                      "type": "int"
                    },
                    "MinimumAmountForBuyIn": {
                      "type": "int"
                    },
                    "OptionType": {
                      "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyTypeEnum",
                      "enum": [
                        "Career",
                        "Training"
                      ]
                    }
                  }
                },
                "MaxPlayers": {
                  "type": "int"
                },
                "MinPlayersToStart": {
                  "type": "int"
                },
                "MoneyUnit": {
                  "type": "int"
                },
                "TableName": {
                  "type": "string"
                },
                "Variant": {
                  "type": "string"
                },
                "WaitingTimes": {
                  "type": "BluffinMuffin.Protocol.DataTypes.ConfigurableWaitingTimes",
                  "properties": {
                    "AfterBoardDealed": {
                      "type": "int"
                    },
                    "AfterPlayerAction": {
                      "type": "int"
                    },
                    "AfterPotWon": {
                      "type": "int"
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

