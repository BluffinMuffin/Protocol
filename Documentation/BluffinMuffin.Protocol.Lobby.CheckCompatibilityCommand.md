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
    "ClientIdentification": {
      "description": "Something to identify what is the client.",
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
  "ImplementedProtocolVersion": "3.0.0",
  "ClientIdentification": "BluffinMuffin.Client .Net 1.0.0"
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
        "InvalidEmail",
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
    "AvailableGames": {
      "description": "The different games available on the server",
      "type": "array",
      "items": {
        "type": "BluffinMuffin.Protocol.DataTypes.GameInfo",
        "properties": {
          "AvailableBlinds": {
            "description": "Available blind types for this type of game",
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
            "description": "Available betting limits for this type of game",
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
          "AvailableVariants": {
            "description": "Available variants of this type of game",
            "type": "array",
            "items": {
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameSubTypeEnum",
              "enum": [
                "TexasHoldem",
                "OmahaHoldem",
                "Pineapple",
                "CrazyPineapple",
                "LazyPineapple",
                "ThreeCardsHoldem",
                "IrishPoker",
                "SpanishPoker",
                "ManilaPoker",
                "FiveCardsStud",
                "SevenCardsStud",
                "FiveCardsDraw"
              ]
            }
          },
          "GameType": {
            "description": "Type of Game",
            "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameTypeEnum",
            "enum": [
              "CommunityCardsPoker",
              "StudPoker",
              "DrawPoker"
            ]
          },
          "MaxPlayers": {
            "description": "Maximum number of player on the table",
            "type": "int"
          },
          "MinPlayers": {
            "description": "Minimum number of player on the table to be able to play the game",
            "type": "int"
          }
        }
      }
    },
    "ImplementedProtocolVersion": {
      "description": "The version of the Implemented Bluffin Protocol by the client, Represented as \"Major.Minor.Revision\"",
      "type": "string"
    },
    "ServerIdentification": {
      "description": "Something to identify what is the server.",
      "type": "string"
    },
    "SupportedLobbyTypes": {
      "description": "The LobbyTypes available on the server",
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
        "ClientIdentification": {
          "description": "Something to identify what is the client.",
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
  "ImplementedProtocolVersion": "3.0.0",
  "SupportedLobbyTypes": [
    "QuickMode",
    "RegisteredMode"
  ],
  "AvailableGames": [
    {
      "GameType": "CommunityCardsPoker",
      "AvailableVariants": [
        "TexasHoldem",
        "OmahaHoldem",
        "CrazyPineapple"
      ],
      "AvailableLimits": [
        "NoLimit",
        "FixedLimit",
        "PotLimit"
      ],
      "AvailableBlinds": [
        "Blinds"
      ],
      "MinPlayers": 2,
      "MaxPlayers": 10
    }
  ],
  "ServerIdentification": "BluffinMuffin.Server .Net 1.0.0",
  "Command": {
    "CommandName": "CheckCompatibilityCommand",
    "ImplementedProtocolVersion": "3.0.0",
    "ClientIdentification": "BluffinMuffin.Client .Net 1.0.0"
  }
}
```

