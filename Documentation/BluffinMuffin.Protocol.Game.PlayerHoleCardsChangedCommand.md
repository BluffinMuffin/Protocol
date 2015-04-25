# Game : PlayerHoleCardsChanged

BluffinMuffin.Protocol.Game.PlayerHoleCardsChangedCommand

## PlayerHoleCardsChangedCommand

### Command Schema

```json
{
  "title": "Schema for PlayerHoleCardsChangedCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerHoleCardsChangedCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerHoleCardsChangedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "CardsId": {
      "type": "array",
      "items": {
        "type": "int"
      }
    },
    "PlayerPos": {
      "type": "int"
    },
    "State": {
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.PlayerStateEnum",
      "enum": [
        "AllIn",
        "Joined",
        "Playing",
        "SitIn",
        "Zombie"
      ]
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
  "CommandName": "PlayerHoleCardsChangedCommand",
  "PlayerPos": 0,
  "CardsId": [],
  "State": "Zombie",
  "TableId": 0
}
```

