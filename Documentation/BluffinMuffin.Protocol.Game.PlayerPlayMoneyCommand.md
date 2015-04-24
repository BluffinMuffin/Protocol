# Game : PlayerPlayMoney

BluffinMuffin.Protocol.Game.PlayerPlayMoneyCommand

## PlayerPlayMoneyCommand

### Command Schema

```json
{
  "title": "Schema for PlayerPlayMoneyCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerPlayMoneyCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerPlayMoneyCommand' to distinguish the command from others.",
      "type": "string"
    },
    "Played": {
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
  "CommandName": "PlayerPlayMoneyCommand",
  "Played": 0,
  "TableId": 0
}
```

