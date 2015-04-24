# Lobby Career : GetUser

BluffinMuffin.Protocol.Lobby.Career.GetUserCommand

## GetUserCommand

### Command Schema

```json
{
  "title": "Schema for GetUserCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'GetUserCommand' to distinguish the command from others.",
      "type": "string"
    },
    "Username": {
      "type": "string"
    }
  }
}```

### Example

## GetUserCommand

### Command Schema

```json
{
  "title": "Schema for GetUserResponse",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'GetUserResponse' to distinguish the command from others.",
      "type": "string"
    },
    "DisplayName": {
      "type": "string"
    },
    "Email": {
      "type": "string"
    },
    "Money": {
      "type": "double"
    },
    "Command": {
      "type": "object",
      "properties": {
        "CommandName": {
          "description": "Always contains 'GetUserCommand' to distinguish the command from others.",
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

