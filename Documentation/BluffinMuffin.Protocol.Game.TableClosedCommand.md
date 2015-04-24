# Game : TableClosed

BluffinMuffin.Protocol.Game.TableClosedCommand

## TableClosedCommand

### Command Schema

```json
{
  "title": "Schema for TableClosedCommand",
  "type": "BluffinMuffin.Protocol.Game.TableClosedCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'TableClosedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "type": "int"
    }
  }
}
```

### Example

