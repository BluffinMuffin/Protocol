# Game : GameStarted

This command is sent at the start of every game.

It's important to understand that a *game* is only one iteration. It's starts with blinds, then preflop, then ends when the pot is won. The next iteration will be a new *game*.

## GameStartedCommand

### Command Schema

```json
{
  "title": "Schema for GameStartedCommand",
  "type": "BluffinMuffin.Protocol.Game.GameStartedCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'GameStartedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "NeededBlind": {
      "description": "The amount needed for this player as blinds. If the player doesn't need to put any blinds, he will receive 0",
      "type": "int"
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
  "CommandName": "GameStartedCommand",
  "NeededBlind": 10,
  "TableId": 42
}
```

