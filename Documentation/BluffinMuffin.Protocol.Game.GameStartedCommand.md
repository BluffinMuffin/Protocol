# Game : GameStarted

BluffinMuffin.Protocol.Game.GameStartedCommand

## GameStartedCommand

### Command Schema

```json
{
  "title": "Schema for GameStartedCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'GameStartedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "NeededBlind": {
      "type": "int"
    },
    "TableId": {
      "type": "int"
    }
  }
}```

### Example

