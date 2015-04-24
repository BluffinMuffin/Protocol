# Game : BetTurnStarted

BluffinMuffin.Protocol.Game.BetTurnStartedCommand

## BetTurnStartedCommand

### Command Schema

```json
{
  "title": "Schema for BetTurnStartedCommand",
  "type": "BluffinMuffin.Protocol.Game.BetTurnStartedCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'BetTurnStartedCommand' to distinguish the command from others.",
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
  "CommandName": "BetTurnStartedCommand",
  "Round": "Preflop",
  "CardsId": [],
  "TableId": 0
}
```

