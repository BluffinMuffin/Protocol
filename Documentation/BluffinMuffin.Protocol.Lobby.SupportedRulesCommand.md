# Lobby : SupportedRules

BluffinMuffin.Protocol.Lobby.SupportedRulesCommand

## SupportedRulesCommand

### Command Schema

```json
{
  "title": "Schema for SupportedRulesCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'SupportedRulesCommand' to distinguish the command from others.",
      "type": "string"
    }
  }
}```

### Example

## SupportedRulesCommand

### Command Schema

```json
{
  "title": "Schema for SupportedRulesResponse",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'SupportedRulesResponse' to distinguish the command from others.",
      "type": "string"
    },
    "Rules": {
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
            "AvailableBlinds": {
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
                  "properties": {}
                }
              }
            },
            "AvailableLimits": {
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
                  "properties": {}
                }
              }
            },
            "AvailableLobbys": {
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
                  "properties": {}
                }
              }
            },
            "CanConfigWaitingTime": {
              "type": "bool"
            },
            "DefaultBlind": {
              "type": "object",
              "properties": {}
            },
            "DefaultLimit": {
              "type": "object",
              "properties": {}
            },
            "GameType": {
              "type": "object",
              "properties": {}
            },
            "MaxPlayers": {
              "type": "int"
            },
            "MinPlayers": {
              "type": "int"
            },
            "Name": {
              "type": "string"
            }
          }
        }
      }
    },
    "Command": {
      "type": "object",
      "properties": {
        "CommandName": {
          "description": "Always contains 'SupportedRulesCommand' to distinguish the command from others.",
          "type": "string"
        }
      }
    }
  }
}```

### Example

