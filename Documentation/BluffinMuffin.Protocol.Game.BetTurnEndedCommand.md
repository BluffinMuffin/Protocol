# Game : BetTurnEnded

BluffinMuffin.Protocol.Game.BetTurnEndedCommand

## BetTurnEndedCommand

### Command Schema

```json
{
  "title": "Schema for BetTurnEndedCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'BetTurnEndedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "PotsAmounts": {
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
    "Round": {
      "type": "object",
      "properties": {}
    },
    "TableId": {
      "type": "int"
    }
  }
}```

### Example

