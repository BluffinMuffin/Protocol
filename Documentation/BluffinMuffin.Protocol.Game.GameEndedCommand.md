# Game : GameEnded

BluffinMuffin.Protocol.Game.GameEndedCommand

## GameEndedCommand

### Command Schema

```json
{
  "title": "Schema for GameEndedCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'GameEndedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "type": "int"
    }
  }
}```

### Example

