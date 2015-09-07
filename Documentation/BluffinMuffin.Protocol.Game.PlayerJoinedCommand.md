# Game : PlayerJoined

This command is there to inform players that someone just joined the table. This will be sent before the player sits in. If the player is only there to view, people are still notified of his presence.

## PlayerJoinedCommand

### Command Schema

```json
{
  "title": "Schema for PlayerJoinedCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerJoinedCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerJoinedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "PlayerName": {
      "description": "The name of the player that just joined the table.",
      "type": "string"
    }
  }
}
```

### Example

```json
{
  "CommandName": "PlayerJoinedCommand",
  "TableId": 42,
  "PlayerName": "SpongeBob"
}
```

