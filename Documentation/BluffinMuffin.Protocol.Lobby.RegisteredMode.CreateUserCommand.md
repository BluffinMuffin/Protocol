# Lobby RegisteredMode : CreateUser

BluffinMuffin.Protocol.Lobby.RegisteredMode.CreateUserCommand

## CreateUserCommand

### Command Schema

```json
{
  "title": "Schema for CreateUserCommand",
  "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.CreateUserCommand",
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

```json
{
  "CommandName": "CreateUserCommand",
  "Username": null,
  "Password": null,
  "Email": null,
  "DisplayName": null
}
```

## CreateUserResponse

### Command Schema

```json
{
  "title": "Schema for CreateUserResponse",
  "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.CreateUserResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CreateUserResponse' to distinguish the command from others.",
      "type": "string"
    },
    "Success": {
      "type": "bool"
    },
    "Command": {
      "description": "The command who initiated this response",
      "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.CreateUserCommand",
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

```json
{
  "CommandName": "CreateUserResponse",
  "Success": false,
  "Command": {
    "CommandName": "CreateUserCommand",
    "Username": null,
    "Password": null,
    "Email": null,
    "DisplayName": null
  }
}
```

