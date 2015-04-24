# Lobby : CreateTable

BluffinMuffin.Protocol.Lobby.CreateTableCommand

## CreateTableCommand

### Command Schema

```json
{
  "title": "Schema for CreateTableCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CreateTableCommand' to distinguish the command from others.",
      "type": "string"
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
    }
  }
}```

### Example

## CreateTableCommand

### Command Schema

```json
{
  "title": "Schema for CreateTableResponse",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CreateTableResponse' to distinguish the command from others.",
      "type": "string"
    },
    "IdTable": {
      "type": "int"
    },
    "Command": {
      "type": "object",
      "properties": {
        "CommandName": {
          "description": "Always contains 'CreateTableCommand' to distinguish the command from others.",
          "type": "string"
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
        }
      }
    }
  }
}```

### Example

