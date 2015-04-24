# Game : PlayerMoneyChanged

BluffinMuffin.Protocol.Game.PlayerMoneyChangedCommand

## PlayerMoneyChangedCommand

### Command Schema

```json
{
  "title": "Schema for PlayerMoneyChangedCommand",
  "type": "object",
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
}```

### Example

