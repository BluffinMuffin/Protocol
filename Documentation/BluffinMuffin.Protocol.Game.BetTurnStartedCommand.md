# Game : BetTurnStarted

BluffinMuffin.Protocol.Game.BetTurnStartedCommand

## BetTurnStartedCommand

### Command Schema

```json
{
  "title": "Schema for BetTurnStartedCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'BetTurnStartedCommand' to distinguish the command from others.",
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

