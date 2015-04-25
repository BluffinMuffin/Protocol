# Lobby RegisteredMode : AuthenticateUser

BluffinMuffin.Protocol.Lobby.RegisteredMode.AuthenticateUserCommand

## AuthenticateUserCommand

### Command Schema

```json
{
  "title": "Schema for AuthenticateUserCommand",
  "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.AuthenticateUserCommand",
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
```

### Example

```json
{
  "CommandName": "AuthenticateUserCommand",
  "Username": null,
  "Password": null
}
```

## AuthenticateUserResponse

### Command Schema

```json
{
  "title": "Schema for AuthenticateUserResponse",
  "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.AuthenticateUserResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'AuthenticateUserResponse' to distinguish the command from others.",
      "type": "string"
    },
    "Success": {
      "type": "bool"
    },
    "Command": {
      "description": "The command who initiated this response",
      "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.AuthenticateUserCommand",
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
}
```

### Example

```json
{
  "CommandName": "AuthenticateUserResponse",
  "Success": false,
  "Command": {
    "CommandName": "AuthenticateUserCommand",
    "Username": null,
    "Password": null
  }
}
```

