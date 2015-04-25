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
      "type": "array",
      "items": {
        "type": "int"
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
  "Round": "Preflop",
  "PotsAmounts": [],
  "TableId": 0
}
```

