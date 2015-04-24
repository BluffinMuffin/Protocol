# Lobby Career : CreateUser

BluffinMuffin.Protocol.Lobby.Career.CreateUserCommand

## CreateUserCommand

### Command Schema

```json
{
  "title": "Schema for CreateUserCommand",
  "type": "BluffinMuffin.Protocol.Lobby.Career.CreateUserCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CreateUserCommand' to distinguish the command from others.",
      "type": "string"
    },
    "DisplayName": {
      "type": "string"
    },
    "Email": {
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
```

### Example

## CreateUserResponse

### Command Schema

```json
{
  "title": "Schema for CreateUserResponse",
  "type": "BluffinMuffin.Protocol.Lobby.Career.CreateUserResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CreateUserResponse' to distinguish the command from others.",
      "type": "string"
    },
    "Success": {
      "type": "bool"
    },
    "Command": {
      "type": "BluffinMuffin.Protocol.Lobby.Career.CreateUserCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'CreateUserCommand' to distinguish the command from others.",
          "type": "string"
        },
        "DisplayName": {
          "type": "string"
        },
        "Email": {
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
}
```

### Example

