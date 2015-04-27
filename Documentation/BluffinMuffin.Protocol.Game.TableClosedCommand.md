# Game : TableClosed

Informs the clients that the table is closed and that there will be no more games on this table.

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
      "description": "The id of the table where this command needs to go",
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "TableClosedCommand",
  "TableId": 42
}
```

