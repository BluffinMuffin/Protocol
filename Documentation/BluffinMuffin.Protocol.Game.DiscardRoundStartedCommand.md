# Game : DiscardRoundStarted

This command is issued by the server when a discard round is starting. All Player must send a PlayerDiscardActionCommand that fits the discard round limitations.

## DiscardRoundStartedCommand

### Command Schema

```json
{
  "title": "Schema for DiscardRoundStartedCommand",
  "type": "BluffinMuffin.Protocol.Game.DiscardRoundStartedCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'DiscardRoundStartedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "MaximumCardsToDiscard": {
      "description": "The maximum number of cards that a player can discard",
      "type": "int"
    },
    "MinimumCardsToDiscard": {
      "description": "The minimum number of cards that a player must discard",
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "DiscardRoundStartedCommand",
  "TableId": 42,
  "MinimumCardsToDiscard": 0,
  "MaximumCardsToDiscard": 5
}
```

