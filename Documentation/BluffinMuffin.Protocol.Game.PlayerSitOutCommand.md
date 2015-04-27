# Game : PlayerSitOut

The client is telling the server that he wants to sit out

## PlayerSitOutCommand

### Command Schema

```json
{
  "title": "Schema for PlayerSitOutCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerSitOutCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerSitOutCommand' to distinguish the command from others.",
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
  "CommandName": "PlayerSitOutCommand",
  "TableId": 42
}
```

## PlayerSitOutResponse

### Command Schema

```json
{
  "title": "Schema for PlayerSitOutResponse",
  "type": "BluffinMuffin.Protocol.Game.PlayerSitOutResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerSitOutResponse' to distinguish the command from others.",
      "type": "string"
    },
    "Success": {
      "description": "The success of the sit out. Usually false if the player was not sitting at the table",
      "type": "bool"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "Command": {
      "description": "The command who initiated this response",
      "type": "BluffinMuffin.Protocol.Game.PlayerSitOutCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'PlayerSitOutCommand' to distinguish the command from others.",
          "type": "string"
        },
        "TableId": {
          "description": "The id of the table where this command needs to go",
          "type": "int"
        }
      }
    }
  }
}
```

### Example

```json
{
  "CommandName": "PlayerSitOutResponse",
  "Success": true,
  "TableId": 42,
  "Command": {
    "CommandName": "PlayerSitOutCommand",
    "TableId": 42
  }
}
```

