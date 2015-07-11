# Game : PlayerDiscardAction

The client is telling the server that he discards some cards.

## PlayerDiscardActionCommand

### Command Schema

```json
{
  "title": "Schema for PlayerDiscardActionCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerDiscardActionCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerDiscardActionCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "CardsDiscarded": {
      "description": "Cards discarded",
      "type": "array",
      "items": {
        "type": "string"
      }
    }
  }
}
```

### Example

```json
{
  "CommandName": "PlayerDiscardActionCommand",
  "TableId": 42,
  "CardsDiscarded": [
    "2s",
    "7c",
    "Kh"
  ]
}
```

