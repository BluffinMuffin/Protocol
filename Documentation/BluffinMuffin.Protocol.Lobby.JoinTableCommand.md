# Lobby : JoinTable

BluffinMuffin.Protocol.Lobby.JoinTableCommand

## JoinTableCommand

### Command Schema

```json
{
  "title": "Schema for JoinTableCommand",
  "type": "object",
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
}```

### Example

## JoinTableCommand

### Command Schema

```json
{
  "title": "Schema for JoinTableResponse",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'JoinTableResponse' to distinguish the command from others.",
      "type": "string"
    },
    "Success": {
      "type": "bool"
    },
    "Command": {
      "type": "object",
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
}```

### Example

