# Game : PlayerSitIn

BluffinMuffin.Protocol.Game.PlayerSitInCommand

## PlayerSitInCommand

### Command Schema

```json
{
  "title": "Schema for PlayerSitInCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerSitInCommand' to distinguish the command from others.",
      "type": "string"
    },
    "MoneyAmount": {
      "type": "int"
    },
    "NoSeat": {
      "type": "int"
    },
    "TableId": {
      "type": "int"
    }
  }
}```

### Example

## PlayerSitInCommand

### Command Schema

```json
{
  "title": "Schema for PlayerSitInResponse",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerSitInResponse' to distinguish the command from others.",
      "type": "string"
    },
    "NoSeat": {
      "type": "int"
    },
    "TableId": {
      "type": "int"
    },
    "Command": {
      "type": "object",
      "properties": {
        "CommandName": {
          "description": "Always contains 'PlayerSitInCommand' to distinguish the command from others.",
          "type": "string"
        },
        "MoneyAmount": {
          "type": "int"
        },
        "NoSeat": {
          "type": "int"
        },
        "TableId": {
          "type": "int"
        }
      }
    }
  }
}```

### Example

