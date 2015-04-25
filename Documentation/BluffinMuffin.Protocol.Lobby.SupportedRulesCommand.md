# Lobby : SupportedRules

BluffinMuffin.Protocol.Lobby.SupportedRulesCommand

## SupportedRulesCommand

### Command Schema

```json
{
  "title": "Schema for SupportedRulesCommand",
  "type": "BluffinMuffin.Protocol.Lobby.SupportedRulesCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'SupportedRulesCommand' to distinguish the command from others.",
      "type": "string"
    }
  }
}
```

### Example

```json
{
  "CommandName": "SupportedRulesCommand"
}
```

## SupportedRulesResponse

### Command Schema

```json
{
  "title": "Schema for SupportedRulesResponse",
  "type": "BluffinMuffin.Protocol.Lobby.SupportedRulesResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'SupportedRulesResponse' to distinguish the command from others.",
      "type": "string"
    },
    "Rules": {
      "type": "System.Collections.Generic.List`1[[BluffinMuffin.Protocol.DataTypes.RuleInfo, BluffinMuffin.Protocol.DataTypes, Version=0.5.0.0, Culture=neutral, PublicKeyToken=null]]",
      "properties": {
        "Capacity": {
          "type": "int"
        },
        "Count": {
          "type": "int"
        },
        "Item": {
          "type": "BluffinMuffin.Protocol.DataTypes.RuleInfo",
          "properties": {
            "AvailableBlinds": {
              "type": "System.Collections.Generic.List`1[[BluffinMuffin.Protocol.DataTypes.Enums.BlindTypeEnum, BluffinMuffin.Protocol.DataTypes, Version=0.5.0.0, Culture=neutral, PublicKeyToken=null]]",
              "properties": {
                "Capacity": {
                  "type": "int"
                },
                "Count": {
                  "type": "int"
                },
                "Item": {
                  "type": "BluffinMuffin.Protocol.DataTypes.Enums.BlindTypeEnum",
                  "enum": [
                    "Antes",
                    "Blinds",
                    "None"
                  ]
                }
              }
            },
            "AvailableLimits": {
              "type": "System.Collections.Generic.List`1[[BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum, BluffinMuffin.Protocol.DataTypes, Version=0.5.0.0, Culture=neutral, PublicKeyToken=null]]",
              "properties": {
                "Capacity": {
                  "type": "int"
                },
                "Count": {
                  "type": "int"
                },
                "Item": {
                  "type": "BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum",
                  "enum": [
                    "FixedLimit",
                    "NoLimit",
                    "PotLimit"
                  ]
                }
              }
            },
            "AvailableLobbys": {
              "type": "System.Collections.Generic.List`1[[BluffinMuffin.Protocol.DataTypes.Enums.LobbyTypeEnum, BluffinMuffin.Protocol.DataTypes, Version=0.5.0.0, Culture=neutral, PublicKeyToken=null]]",
              "properties": {
                "Capacity": {
                  "type": "int"
                },
                "Count": {
                  "type": "int"
                },
                "Item": {
                  "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyTypeEnum",
                  "enum": [
                    "QuickMode",
                    "RegisteredMode"
                  ]
                }
              }
            },
            "CanConfigWaitingTime": {
              "type": "bool"
            },
            "DefaultBlind": {
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.BlindTypeEnum",
              "enum": [
                "Antes",
                "Blinds",
                "None"
              ]
            },
            "DefaultLimit": {
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum",
              "enum": [
                "FixedLimit",
                "NoLimit",
                "PotLimit"
              ]
            },
            "GameType": {
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameTypeEnum",
              "enum": [
                "Holdem"
              ]
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
      "type": "BluffinMuffin.Protocol.Lobby.SupportedRulesCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'SupportedRulesCommand' to distinguish the command from others.",
          "type": "string"
        }
      }
    }
  }
}
```

### Example

```json
{
  "CommandName": "SupportedRulesResponse",
  "Rules": [],
  "Command": {
    "CommandName": "SupportedRulesCommand"
  }
}
```

