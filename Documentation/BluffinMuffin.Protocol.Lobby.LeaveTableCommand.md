# Lobby : LeaveTable

To leave a table, you have to send a **Leave Table ** command with the id of the table you want to leave.

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/BluffinMuffin.Protocol.Lobby.LeaveTableCommand.png" alt="Sequence Diagram"></p>

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/BluffinMuffin.Protocol.Lobby.LeaveTableCommand.png" alt="Activity Diagram"></p>

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

