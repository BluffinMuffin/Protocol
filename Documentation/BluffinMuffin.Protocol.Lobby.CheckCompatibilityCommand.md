# Lobby : CheckCompatibility

This should be sent one time, at the beginning, to know what the server can do.

The supported version, all the supported lobby types and all the supported rules are then sent back to the client.

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/BluffinMuffin.Protocol.Lobby.CheckCompatibilityCommand.png" alt="Sequence Diagram"></p>

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/BluffinMuffin.Protocol.Lobby.CheckCompatibilityCommand.png" alt="Activity Diagram"></p>

## CheckCompatibilityCommand

### Command Schema

```json
{
  "title": "Schema for CheckCompatibilityCommand",
  "type": "BluffinMuffin.Protocol.Lobby.CheckCompatibilityCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CheckCompatibilityCommand' to distinguish the command from others.",
      "type": "string"
    },
    "ImplementedProtocolVersion": {
      "description": "The version of the Implemented Bluffin Protocol by the client, Represented as \"Major.Minor.Revision\"",
      "type": "string"
    }
  }
}
```

### Example

```json
{
  "CommandName": "CheckCompatibilityCommand",
  "ImplementedProtocolVersion": "2.0.0"
}
```

## CheckCompatibilityResponse

### Command Schema

```json
{
  "title": "Schema for CheckCompatibilityResponse",
  "type": "BluffinMuffin.Protocol.Lobby.CheckCompatibilityResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CheckCompatibilityResponse' to distinguish the command from others.",
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
        "InvalidPassword",
        "SeatChanged",
        "NoMoreSeats",
        "NotAuthenticated",
        "WrongLobbyType",
        "NotSupported"
      ]
    },
    "Message": {
      "description": "The message. Empty if no messages",
      "type": "string"
    },
    "ImplementedProtocolVersion": {
      "description": "The version of the Implemented Bluffin Protocol by the client, Represented as \"Major.Minor.Revision\"",
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
    "SupportedLobbyTypes": {
      "description": "All the rules supported by the server",
      "type": "array",
      "items": {
        "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyTypeEnum",
        "enum": [
          "QuickMode",
          "RegisteredMode"
        ]
      }
    },
    "Command": {
      "description": "The command who initiated this response",
      "type": "BluffinMuffin.Protocol.Lobby.CheckCompatibilityCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'CheckCompatibilityCommand' to distinguish the command from others.",
          "type": "string"
        },
        "ImplementedProtocolVersion": {
          "description": "The version of the Implemented Bluffin Protocol by the client, Represented as \"Major.Minor.Revision\"",
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
  "CommandName": "CheckCompatibilityResponse",
  "Success": true,
  "MessageId": "None",
  "Message": "",
  "ImplementedProtocolVersion": "2.0.0",
  "SupportedLobbyTypes": [
    "QuickMode",
    "RegisteredMode"
  ],
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
    "CommandName": "CheckCompatibilityCommand",
    "ImplementedProtocolVersion": "2.0.0"
  }
}
```

