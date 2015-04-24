# Game : GameStarted

BluffinMuffin.Protocol.Game.GameStartedCommand

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
      "type": "int"
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
  "CommandName": "GameStartedCommand",
  "NeededBlind": 0,
  "TableId": 0
}
```

