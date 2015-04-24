# Game : TableInfo

BluffinMuffin.Protocol.Game.TableInfoCommand

## TableInfoCommand

### Command Schema

```json
{
  "title": "Schema for TableInfoCommand",
  "type": "BluffinMuffin.Protocol.Game.TableInfoCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'TableInfoCommand' to distinguish the command from others.",
      "type": "string"
    },
    "BoardCardIDs": {
      "type": "System.Collections.Generic.List`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]",
      "properties": {
        "Capacity": {
          "type": "int"
        },
        "Count": {
          "type": "int"
        },
        "Item": {
          "type": "int"
        }
      }
    },
    "GameHasStarted": {
      "type": "bool"
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
    "PotsAmount": {
      "type": "System.Collections.Generic.List`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]",
      "properties": {
        "Capacity": {
          "type": "int"
        },
        "Count": {
          "type": "int"
        },
        "Item": {
          "type": "int"
        }
      }
    },
    "Seats": {
      "type": "System.Collections.Generic.List`1[[BluffinMuffin.Protocol.DataTypes.SeatInfo, BluffinMuffin.Protocol.DataTypes, Version=0.5.0.0, Culture=neutral, PublicKeyToken=null]]",
      "properties": {
        "Capacity": {
          "type": "int"
        },
        "Count": {
          "type": "int"
        },
        "Item": {
          "type": "BluffinMuffin.Protocol.DataTypes.SeatInfo",
          "properties": {
            "IsEmpty": {
              "type": "bool"
            },
            "NoSeat": {
              "type": "int"
            },
            "Player": {
              "type": "BluffinMuffin.Protocol.DataTypes.PlayerInfo",
              "properties": {
                "HoleCards": {
                  "type": "Com.Ericmas001.Games.GameCard[]",
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
                },
                "IsShowingCards": {
                  "type": "bool"
                },
                "MoneyAmnt": {
                  "type": "int"
                },
                "MoneyBetAmnt": {
                  "type": "int"
                },
                "MoneySafeAmnt": {
                  "type": "int"
                },
                "Name": {
                  "type": "string"
                },
                "NoSeat": {
                  "type": "int"
                },
                "State": {
                  "type": "BluffinMuffin.Protocol.DataTypes.Enums.PlayerStateEnum",
                  "enum": [
                    "AllIn",
                    "Joined",
                    "Playing",
                    "SitIn",
                    "Zombie"
                  ]
                }
              }
            },
            "SerializableAttributes": {
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.SeatAttributeEnum[]",
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
    },
    "TableId": {
      "type": "int"
    },
    "TotalPotAmount": {
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "TableInfoCommand",
  "Params": {
    "TableName": "Anonymous Table",
    "GameType": 0,
    "Variant": "Texas Hold'Em",
    "MinPlayersToStart": 2,
    "MaxPlayers": 10,
    "WaitingTimes": {
      "AfterPlayerAction": 0,
      "AfterBoardDealed": 0,
      "AfterPotWon": 0
    },
    "MoneyUnit": 10,
    "Lobby": null,
    "Blind": null,
    "Limit": null
  },
  "TotalPotAmount": 0,
  "PotsAmount": [],
  "BoardCardIDs": [],
  "NbPlayers": 0,
  "Seats": [],
  "GameHasStarted": false,
  "TableId": 0
}
```

