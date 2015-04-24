# Game : PlayerTurnBegan

BluffinMuffin.Protocol.Game.PlayerTurnBeganCommand

## PlayerTurnBeganCommand

### Command Schema

```json
{
  "title": "Schema for PlayerTurnBeganCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerTurnBeganCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerTurnBeganCommand' to distinguish the command from others.",
      "type": "string"
    },
    "LastPlayerNoSeat": {
      "type": "int"
    },
    "MinimumRaise": {
      "type": "int"
    },
    "PlayerPos": {
      "type": "int"
    },
    "TableId": {
      "type": "int"
    }
  }
}
```

### Example

