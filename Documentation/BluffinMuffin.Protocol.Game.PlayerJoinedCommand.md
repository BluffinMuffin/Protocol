# Game : PlayerJoined

BluffinMuffin.Protocol.Game.PlayerJoinedCommand

## PlayerJoinedCommand

### Command Schema

```json
{
  "title": "Schema for PlayerJoinedCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerJoinedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "PlayerName": {
      "type": "string"
    },
    "TableId": {
      "type": "int"
    }
  }
}```

### Example

