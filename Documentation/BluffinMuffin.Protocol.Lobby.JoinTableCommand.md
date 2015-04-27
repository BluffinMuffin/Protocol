# Lobby : JoinTable

To join a table, you have to send a **Join Table ** command with the id of the table you want to join.

The success of the operation will be sent back

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/BluffinMuffin.Protocol.Lobby.JoinTableCommand.png" alt="Sequence Diagram"></p>

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/BluffinMuffin.Protocol.Lobby.JoinTableCommand.png" alt="Activity Diagram"></p>

## JoinTableCommand

### Command Schema

```json
{
  "title": "Schema for JoinTableCommand",
  "type": "BluffinMuffin.Protocol.Lobby.JoinTableCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'JoinTableCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table to join",
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "JoinTableCommand",
  "TableId": 42
}
```

## JoinTableResponse

### Command Schema

```json
{
  "title": "Schema for JoinTableResponse",
  "type": "BluffinMuffin.Protocol.Lobby.JoinTableResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'JoinTableResponse' to distinguish the command from others.",
      "type": "string"
    },
    "Success": {
      "description": "true if the player has joined the table on the server",
      "type": "bool"
    },
    "Command": {
      "description": "The command who initiated this response",
      "type": "BluffinMuffin.Protocol.Lobby.JoinTableCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'JoinTableCommand' to distinguish the command from others.",
          "type": "string"
        },
        "TableId": {
          "description": "The id of the table to join",
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
  "CommandName": "JoinTableResponse",
  "Success": false,
  "Command": {
    "CommandName": "JoinTableCommand",
    "TableId": 42
  }
}
```

