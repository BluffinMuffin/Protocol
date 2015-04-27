# Game : GameEnded

This command is sent at the end of every game.

It's important to understand that a *game* is only one iteration. It's starts with blinds, then preflop, then ends when the pot is won. The next iteration will be a new *game*.

## GameEndedCommand

### Command Schema

```json
{
  "title": "Schema for GameEndedCommand",
  "type": "BluffinMuffin.Protocol.Game.GameEndedCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'GameEndedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "GameEndedCommand",
  "TableId": 42
}
```

