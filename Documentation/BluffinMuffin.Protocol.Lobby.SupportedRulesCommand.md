# Lobby : SupportedRules

This should be sent one time, at the beginning, to know what the server can do.

All the supported rules are then sent back to the client.

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/BluffinMuffin.Protocol.Lobby.SupportedRulesCommand.png" alt="Sequence Diagram"></p>

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/BluffinMuffin.Protocol.Lobby.SupportedRulesCommand.png" alt="Activity Diagram"></p>

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
    "Success": {
      "description": "True if the command was a success",
      "type": "bool"
    },
    "MessageId": {
      "description": "The Id of the message. None if no message",
      "type": "BluffinMuffin.Protocol.Enums.BluffinMessageId",
      "enum": [
        "None",
        "SpecificServerMessage",
        "WrongTableState",
        "NameAlreadyUsed",
        "UsernameAlreadyUsed",
        "UsernameNotFound",
        "InvalidPassword"
      ]
    },
    "Message": {
      "description": "The message. Empty if no messages",
      "type": "string"
    },
    "Rules": {
      "description": "All the rules supported by the server",
      "type": "array",
      "items": {
        "type": "BluffinMuffin.Protocol.DataTypes.RuleInfo",
        "properties": {
          "AvailableBlinds": {
            "description": "Available Blind Options",
            "type": "array",
            "items": {
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.BlindTypeEnum",
              "enum": [
                "Blinds",
                "Antes",
                "None"
              ]
            }
          },
          "AvailableLimits": {
            "description": "Avaliable limits",
            "type": "array",
            "items": {
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum",
              "enum": [
                "NoLimit",
                "FixedLimit",
                "PotLimit"
              ]
            }
          },
          "AvailableLobbys": {
            "description": "What kind of lobby are offered ?",
            "type": "array",
            "items": {
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyTypeEnum",
              "enum": [
                "QuickMode",
                "RegisteredMode"
              ]
            }
          },
          "CanConfigWaitingTime": {
            "description": "Are waiting times configurable ?? (At different stage of the game, the server will wait before continuing to making it feel real !)",
            "type": "bool"
          },
          "DefaultBlind": {
            "description": "Default Blind Option",
            "type": "BluffinMuffin.Protocol.DataTypes.Enums.BlindTypeEnum",
            "enum": [
              "Blinds",
              "Antes",
              "None"
            ]
          },
          "DefaultLimit": {
            "description": "Default Limit",
            "type": "BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum",
            "enum": [
              "NoLimit",
              "FixedLimit",
              "PotLimit"
            ]
          },
          "GameType": {
            "description": "Type of Game",
            "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameTypeEnum",
            "enum": [
              "Holdem"
            ]
          },
          "MaxPlayers": {
            "description": "Maximum amount of players that can sit at the table (Must be >= MinPlayers)",
            "type": "int"
          },
          "MinPlayers": {
            "description": "Minimum amount of sitting player required to start a game",
            "type": "int"
          },
          "Name": {
            "description": "Name of the Variant",
            "type": "string"
          }
        }
      }
    },
    "Command": {
      "description": "The command who initiated this response",
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
  "Success": true,
  "MessageId": "None",
  "Message": "",
  "Rules": [
    {
      "GameType": "Holdem",
      "Name": "Texas Hold'em",
      "MinPlayers": 2,
      "MaxPlayers": 10,
      "AvailableLimits": [
        "NoLimit"
      ],
      "DefaultLimit": "NoLimit",
      "AvailableBlinds": [
        "Blinds",
        "Antes",
        "None"
      ],
      "DefaultBlind": "Blinds",
      "CanConfigWaitingTime": true,
      "AvailableLobbys": [
        "QuickMode",
        "RegisteredMode"
      ]
    }
  ],
  "Command": {
    "CommandName": "SupportedRulesCommand"
  }
}
```

