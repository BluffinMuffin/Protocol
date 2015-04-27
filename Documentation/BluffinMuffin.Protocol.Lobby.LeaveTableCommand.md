# Lobby : LeaveTable

To leave a table, you have to send a **Leave Table ** command with the id of the table you want to leave.

## LeaveTableCommand

### Command Schema

```json
{
  "title": "Schema for LeaveTableCommand",
  "type": "BluffinMuffin.Protocol.Lobby.LeaveTableCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'LeaveTableCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table to leave",
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "LeaveTableCommand",
  "TableId": 42
}
```

