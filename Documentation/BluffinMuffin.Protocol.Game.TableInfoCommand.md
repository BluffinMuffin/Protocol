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
                  "description": "true if the player cards are public (ex: during showdown)",
                  "type": "bool"
                },
                "MoneyAmnt": {
                  "description": "Current Money Amount of the player (Safe + Bet)",
                  "type": "int"
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
    "TableName": "Bikini Bottom",
    "GameType": "Holdem",
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
      "OptionType": "Training",
      "StartingAmount": 1500
    },
    "Blind": {
      "OptionType": "Blinds",
      "BigBlindAmount": 0,
      "SmallBlindAmount": 0,
      "MoneyUnit": 0
    },
    "Limit": {
      "OptionType": "NoLimit"
    }
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

