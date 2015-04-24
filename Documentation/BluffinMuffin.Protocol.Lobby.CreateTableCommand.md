# Lobby : CreateTable

BluffinMuffin.Protocol.Lobby.CreateTableCommand

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
    }
  }
}
```

### Example

```json
{
  "CommandName": "CreateTableCommand",
  "Params": {
    "TableName": "Anonymous Table",
    "GameType": "Holdem",
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
    "IdTable": {
      "type": "int"
    },
    "Command": {
      "type": "BluffinMuffin.Protocol.Lobby.CreateTableCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'CreateTableCommand' to distinguish the command from others.",
          "type": "string"
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
  "IdTable": 0,
  "Command": {
    "CommandName": "CreateTableCommand",
    "Params": {
      "TableName": "Anonymous Table",
      "GameType": "Holdem",
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
    }
  }
}
```

