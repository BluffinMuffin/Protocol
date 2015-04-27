# Game : PlayerTurnBegan

The server sends this command to indicated that it's time for a specific player to play.

## PlayerTurnBeganCommand

### Command Schema

```json
{
  "title": "Schema for PlayerTurnBeganCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerTurnBeganCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerTurnBeganCommand' to distinguish the command from others.",
      "type": "string"
    },
    "MinimumRaise": {
      "description": "The minimum amount needed to raise. A raise must be at least the size of the largest previous bet or raise of the current betting round.",
      "type": "int"
    },
    "PlayerPos": {
      "description": "The position on the table where is sitting the player that needs to play",
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
  "CommandName": "PlayerTurnBeganCommand",
  "PlayerPos": 7,
  "MinimumRaise": 6,
  "TableId": 42
}
```

