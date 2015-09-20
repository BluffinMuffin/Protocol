# Game : PlayerSitOut

The client is telling the server that he wants to sit out

## PlayerSitOutCommand

### Command Schema

```json
{
  "title": "Schema for PlayerSitOutCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerSitOutCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerSitOutCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "PlayerSitOutCommand",
  "TableId": 42
}
```

## PlayerSitOutResponse

### Command Schema

```json
{
  "title": "Schema for PlayerSitOutResponse",
  "type": "BluffinMuffin.Protocol.Game.PlayerSitOutResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerSitOutResponse' to distinguish the command from others.",
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
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "Command": {
      "description": "The command who initiated this response",
      "type": "BluffinMuffin.Protocol.Game.PlayerSitOutCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'PlayerSitOutCommand' to distinguish the command from others.",
          "type": "string"
        },
        "TableId": {
          "description": "The id of the table where this command needs to go",
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
  "CommandName": "PlayerSitOutResponse",
  "Success": true,
  "MessageId": "None",
  "Message": "",
  "TableId": 42,
  "Command": {
    "CommandName": "PlayerSitOutCommand",
    "TableId": 42
  }
}
```

