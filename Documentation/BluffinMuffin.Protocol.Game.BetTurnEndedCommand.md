# Game : BetTurnEnded

BluffinMuffin.Protocol.Game.BetTurnEndedCommand

## BetTurnEndedCommand

### Command Schema

```json
{
  "title": "Schema for BetTurnEndedCommand",
  "type": "BluffinMuffin.Protocol.Game.BetTurnEndedCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'BetTurnEndedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "PotsAmounts": {
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
    "Round": {
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.RoundTypeEnum",
      "enum": [
        "Flop",
        "Preflop",
        "River",
        "Turn"
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
  "CommandName": "BetTurnEndedCommand",
  "Round": 0,
  "PotsAmounts": [],
  "TableId": 0
}
```

