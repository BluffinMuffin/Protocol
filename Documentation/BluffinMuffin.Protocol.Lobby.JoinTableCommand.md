# Lobby : JoinTable

BluffinMuffin.Protocol.Lobby.JoinTableCommand

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
    "PlayerName": {
      "type": "string"
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
  "CommandName": "JoinTableCommand",
  "TableId": 0,
  "PlayerName": null
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
        "PlayerName": {
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

```json
{
  "CommandName": "JoinTableResponse",
  "Success": false,
  "Command": {
    "CommandName": "JoinTableCommand",
    "TableId": 0,
    "PlayerName": null
  }
}
```

