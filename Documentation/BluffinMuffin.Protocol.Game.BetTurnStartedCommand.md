# Game : BetTurnStarted

This command is issued by the server when a betting round is ending. For example, when the 3 first cards are shown, it's the beginning of the flop.

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
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "CardsId": {
      "description": "All the card ids currently visible on the board (Preflop: empty, flop: 3 cars, turn: 4 cards, river: 5 cards)",
      "type": "array",
      "items": {
        "type": "int"
      }
    },
    "Round": {
      "description": "The round that is ending",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.RoundTypeEnum",
      "enum": [
        "Flop",
        "Preflop",
        "River",
        "Turn"
      ]
    }
  }
}
```

### Example

```json
{
  "CommandName": "BetTurnStartedCommand",
  "TableId": 42,
  "Round": "Flop",
  "CardsId": [
    21,
    42,
    7
  ]
}
```

