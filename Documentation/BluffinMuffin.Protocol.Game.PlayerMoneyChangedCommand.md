# Game : PlayerMoneyChanged

BluffinMuffin.Protocol.Game.PlayerMoneyChangedCommand

## PlayerMoneyChangedCommand

### Command Schema

```json
{
  "title": "Schema for PlayerMoneyChangedCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerMoneyChangedCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerMoneyChangedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "PlayerMoney": {
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

