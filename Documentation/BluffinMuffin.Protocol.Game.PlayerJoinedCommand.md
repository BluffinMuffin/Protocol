# Game : PlayerJoined

BluffinMuffin.Protocol.Game.PlayerJoinedCommand

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
    "PlayerName": {
      "type": "string"
    },
    "TableId": {
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "PlayerJoinedCommand",
  "PlayerName": null,
  "TableId": 0
}
```

