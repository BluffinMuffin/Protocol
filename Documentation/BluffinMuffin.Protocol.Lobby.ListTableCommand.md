# Lobby : ListTable

BluffinMuffin.Protocol.Lobby.ListTableCommand

## ListTableCommand

### Command Schema

```json
{
  "title": "Schema for ListTableCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'ListTableCommand' to distinguish the command from others.",
      "type": "string"
    },
    "LobbyTypes": {
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
}```

### Example

## ListTableCommand

### Command Schema

```json
{
  "title": "Schema for ListTableResponse",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'ListTableResponse' to distinguish the command from others.",
      "type": "string"
    },
    "Tables": {
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
            "PossibleAction": {
              "type": "object",
              "properties": {}
            }
          }
        }
      }
    },
    "Command": {
      "type": "object",
      "properties": {
        "CommandName": {
          "description": "Always contains 'ListTableCommand' to distinguish the command from others.",
          "type": "string"
        },
        "LobbyTypes": {
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
}```

### Example

