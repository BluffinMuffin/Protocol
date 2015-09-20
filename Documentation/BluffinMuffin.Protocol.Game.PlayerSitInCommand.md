# Game : PlayerSitIn

The client is telling the server that he wants to sit at a specific seat

## PlayerSitInCommand

### Command Schema

```json
{
  "title": "Schema for PlayerSitInCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerSitInCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerSitInCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "MoneyAmount": {
      "description": "The amount of money the player will be playing with.",
      "type": "int"
    },
    "NoSeat": {
      "description": "The seat where the player wants to sit.",
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "PlayerSitInCommand",
  "TableId": 42,
  "NoSeat": 7,
  "MoneyAmount": 4200
}
```

## PlayerSitInResponse

### Command Schema

```json
{
  "title": "Schema for PlayerSitInResponse",
  "type": "BluffinMuffin.Protocol.Game.PlayerSitInResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerSitInResponse' to distinguish the command from others.",
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
    "NoSeat": {
      "description": "The Seat number where the player will sit. It could be different from the one asked if the seat was not available. Wil have -1 if the player is not sitting anywhere.",
      "type": "int"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "Command": {
      "description": "The command who initiated this response",
      "type": "BluffinMuffin.Protocol.Game.PlayerSitInCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'PlayerSitInCommand' to distinguish the command from others.",
          "type": "string"
        },
        "TableId": {
          "description": "The id of the table where this command needs to go",
          "type": "int"
        },
        "MoneyAmount": {
          "description": "The amount of money the player will be playing with.",
          "type": "int"
        },
        "NoSeat": {
          "description": "The seat where the player wants to sit.",
          "type": "int"
        }
      }
    }
  }
}
```

### Example

```json
{
  "CommandName": "PlayerSitInResponse",
  "Success": true,
  "MessageId": "None",
  "Message": "",
  "NoSeat": 7,
  "TableId": 42,
  "Command": {
    "CommandName": "PlayerSitInCommand",
    "TableId": 42,
    "NoSeat": 7,
    "MoneyAmount": 4200
  }
}
```

