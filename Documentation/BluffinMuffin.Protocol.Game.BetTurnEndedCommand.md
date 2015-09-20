# Game : BetTurnEnded

This command is issued by the server when a betting round is ending. For example, everybody called on the flop. It's the end of the flop. Every client receive this command.

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
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "PotsAmounts": {
      "description": "All the pots on the table. Usually only one, but can have more if some players are all-in.",
      "type": "array",
      "items": {
        "type": "int"
      }
    }
  }
}
```

### Example

```json
{
  "CommandName": "BetTurnEndedCommand",
  "TableId": 42,
  "PotsAmounts": [
    4200,
    420
  ]
}
```

