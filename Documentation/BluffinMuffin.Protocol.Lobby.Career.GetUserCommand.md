# Lobby Career : GetUser

BluffinMuffin.Protocol.Lobby.Career.GetUserCommand

## GetUserCommand

### Command Schema

```json
{
  "title": "Schema for GetUserCommand",
  "type": "BluffinMuffin.Protocol.Lobby.Career.GetUserCommand",
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
```

### Example

```json
{
  "CommandName": "GetUserCommand",
  "Username": null
}
```

## GetUserResponse

### Command Schema

```json
{
  "title": "Schema for GetUserResponse",
  "type": "BluffinMuffin.Protocol.Lobby.Career.GetUserResponse",
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
      "type": "BluffinMuffin.Protocol.Lobby.Career.GetUserCommand",
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
}
```

### Example

```json
{
  "CommandName": "GetUserResponse",
  "Email": null,
  "DisplayName": null,
  "Money": 0.0,
  "Command": {
    "CommandName": "GetUserCommand",
    "Username": null
  }
}
```

