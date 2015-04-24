# Game : PlayerHoleCardsChanged

BluffinMuffin.Protocol.Game.PlayerHoleCardsChangedCommand

## PlayerHoleCardsChangedCommand

### Command Schema

```json
{
  "title": "Schema for PlayerHoleCardsChangedCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerHoleCardsChangedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "CardsId": {
      "type": "object",
      "properties": {
        "Capacity": {
          "type": "int"
        },
        "Count": {
          "type": "int"
        },
        "Item": {
          "type": "int"
        }
      }
    },
    "PlayerPos": {
      "type": "int"
    },
    "State": {
      "type": "object",
      "properties": {}
    },
    "TableId": {
      "type": "int"
    }
  }
}```

### Example
