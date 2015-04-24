# Game : PlayerSitOut

BluffinMuffin.Protocol.Game.PlayerSitOutCommand

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
      "type": "int"
    }
  }
}
```

### Example

## PlayerSitOutCommand

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
      "type": "bool"
    },
    "TableId": {
      "type": "int"
    },
    "Command": {
      "type": "BluffinMuffin.Protocol.Game.PlayerSitOutCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'PlayerSitOutCommand' to distinguish the command from others.",
          "type": "string"
        },
        "TableId": {
          "type": "int"
        }
      }
    }
  }
}
```

### Example

