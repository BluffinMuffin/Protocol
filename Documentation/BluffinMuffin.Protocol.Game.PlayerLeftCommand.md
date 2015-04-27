# Game : PlayerLeft

This command is there to inform players that someone just **left** the table. (Sitting out doesn't mean leaving)

## PlayerLeftCommand

### Command Schema

```json
{
  "title": "Schema for PlayerLeftCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerLeftCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerLeftCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "PlayerName": {
      "description": "The name of the player that just left the table.",
      "type": "string"
    }
  }
}
```

### Example

```json
{
  "CommandName": "PlayerLeftCommand",
  "TableId": 42,
  "PlayerName": null
}
```

