# Game : TableInfo

BluffinMuffin.Protocol.Game.TableInfoCommand

## TableInfoCommand

### Command Schema

```json
{
  "title": "Schema for TableInfoCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'TableInfoCommand' to distinguish the command from others.",
      "type": "string"
    },
    "BoardCardIDs": {
      "type": "object",
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
      "type": "object",
      "properties": {
        "Blind": {
          "type": "object",
          "properties": {
            "MoneyUnit": {
              "type": "int"
            },
            "OptionType": {
              "type": "object",
              "properties": {}
            }
          }
        },
        "GameType": {
          "type": "object",
          "properties": {}
        },
        "Limit": {
          "type": "object",
          "properties": {
            "OptionType": {
              "type": "object",
              "properties": {}
            }
          }
        },
        "Lobby": {
          "type": "object",
          "properties": {
            "MaximumAmountForBuyIn": {
              "type": "int"
            },
            "MinimumAmountForBuyIn": {
              "type": "int"
            },
            "OptionType": {
              "type": "object",
              "properties": {}
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
          "type": "object",
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
      "type": "object",
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
      "type": "object",
      "properties": {
        "Capacity": {
          "type": "int"
        },
        "Count": {
          "type": "int"
        },
        "Item": {
          "type": "object",
          "properties": {
            "IsEmpty": {
              "type": "bool"
            },
            "NoSeat": {
              "type": "int"
            },
            "Player": {
              "type": "object",
              "properties": {
                "HoleCards": {
                  "type": "object",
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
                      "type": "object",
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
                  "type": "object",
                  "properties": {}
                }
              }
            },
            "SerializableAttributes": {
              "type": "object",
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
                  "type": "object",
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
}```

### Example

