# Lobby Career : CheckUserExist

BluffinMuffin.Protocol.Lobby.Career.CheckUserExistCommand

## CheckUserExistCommand

### Command Schema

```json
{
  "title": "Schema for CheckUserExistCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CheckUserExistCommand' to distinguish the command from others.",
      "type": "string"
    },
    "Username": {
      "type": "string"
    }
  }
}```

### Example

## CheckUserExistCommand

### Command Schema

```json
{
  "title": "Schema for CheckUserExistResponse",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CheckUserExistResponse' to distinguish the command from others.",
      "type": "string"
    },
    "Exist": {
      "type": "bool"
    },
    "Command": {
      "type": "object",
      "properties": {
        "CommandName": {
          "description": "Always contains 'CheckUserExistCommand' to distinguish the command from others.",
          "type": "string"
        },
        "Username": {
          "type": "string"
        }
      }
    }
  }
}```

### Example

