# Lobby Career : AuthenticateUser

BluffinMuffin.Protocol.Lobby.Career.AuthenticateUserCommand

## AuthenticateUserCommand

### Command Schema

```json
{
  "title": "Schema for AuthenticateUserCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'AuthenticateUserCommand' to distinguish the command from others.",
      "type": "string"
    },
    "Password": {
      "type": "string"
    },
    "Username": {
      "type": "string"
    }
  }
}```

### Example

## AuthenticateUserCommand

### Command Schema

```json
{
  "title": "Schema for AuthenticateUserResponse",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'AuthenticateUserResponse' to distinguish the command from others.",
      "type": "string"
    },
    "Success": {
      "type": "bool"
    },
    "Command": {
      "type": "object",
      "properties": {
        "CommandName": {
          "description": "Always contains 'AuthenticateUserCommand' to distinguish the command from others.",
          "type": "string"
        },
        "Password": {
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

