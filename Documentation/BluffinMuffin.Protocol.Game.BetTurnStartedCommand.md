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
    "BettingRoundId": {
      "description": "The id of the betting round that is starting, starting at 1. For texas hold'em, Preflop=1, Flop=2, Turn=3, River=4",
      "type": "int"
    },
    "Cards": {
      "description": "All the card ids currently visible on the board (Preflop: empty, flop: 3 cards, turn: 4 cards, river: 5 cards)",
      "type": "array",
      "items": {
        "type": "string"
      }
    },
    "Round": {
      "description": "OBSOLETE: The round that is starting",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.RoundTypeEnum",
      "enum": [
        "Preflop",
        "Flop",
        "Turn",
        "River"
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
  "BettingRoundId": 1,
  "Cards": [
    "2s",
    "Kh",
    "5d"
  ]
}
```

