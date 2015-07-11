# Game : DiscardRoundEnded

This command is issued by the server when a discard round is ending, after all players have sent a PlayerDiscardActionCommand that fits the discard round limitations.

## DiscardRoundEndedCommand

### Command Schema

```json
{
  "title": "Schema for DiscardRoundEndedCommand",
  "type": "BluffinMuffin.Protocol.Game.DiscardRoundEndedCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'DiscardRoundEndedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "CardsDiscarded": {
      "description": "The minimum number of cards that a player must discard",
      "type": "array",
      "items": {
        "type": "BluffinMuffin.Protocol.DataTypes.DiscardInfo",
        "properties": {
          "NbCardsDiscarded": {
            "description": "How many cards discarded by the player",
            "type": "int"
          },
          "NoSeat": {
            "description": "The id of the current seat",
            "type": "int"
          }
        }
      }
    }
  }
}
```

### Example

```json
{
  "CommandName": "DiscardRoundEndedCommand",
  "TableId": 42,
  "CardsDiscarded": [
    {
      "NoSeat": 7,
      "NbCardsDiscarded": 3
    }
  ]
}
```

