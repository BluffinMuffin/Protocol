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
      "type": "System.Collections.Generic.List`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]",
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

