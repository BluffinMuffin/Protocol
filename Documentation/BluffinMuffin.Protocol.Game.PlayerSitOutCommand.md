# Game : PlayerSitOut

BluffinMuffin.Protocol.Game.PlayerSitOutCommand

## PlayerSitOutCommand

### Command Schema

```json
{
  "title": "Schema for PlayerSitOutCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerSitOutCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "type": "int"
    }
  }
}```

### Example

## PlayerSitOutCommand

### Command Schema

```json
{
  "title": "Schema for PlayerSitOutResponse",
  "type": "object",
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
      "type": "object",
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
}```

### Example

