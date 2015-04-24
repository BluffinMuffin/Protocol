# Game : PlayerSitIn

BluffinMuffin.Protocol.Game.PlayerSitInCommand

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
```

### Example

```json
{
  "CommandName": "PlayerSitInCommand",
  "NoSeat": 0,
  "MoneyAmount": 0,
  "TableId": 0
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
    "NoSeat": {
      "type": "int"
    },
    "TableId": {
      "type": "int"
    },
    "Command": {
      "type": "BluffinMuffin.Protocol.Game.PlayerSitInCommand",
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
}
```

### Example

```json
{
  "CommandName": "PlayerSitInResponse",
  "NoSeat": 0,
  "TableId": 0,
  "Command": {
    "CommandName": "PlayerSitInCommand",
    "NoSeat": 0,
    "MoneyAmount": 0,
    "TableId": 0
  }
}
```

