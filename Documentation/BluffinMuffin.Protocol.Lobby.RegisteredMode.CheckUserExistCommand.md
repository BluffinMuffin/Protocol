# Lobby RegisteredMode : CheckUserExist

BluffinMuffin.Protocol.Lobby.RegisteredMode.CheckUserExistCommand

## CheckUserExistCommand

### Command Schema

```json
{
  "title": "Schema for CheckUserExistCommand",
  "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.CheckUserExistCommand",
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
```

### Example

```json
{
  "CommandName": "CheckUserExistCommand",
  "Username": null
}
```

## CheckUserExistResponse

### Command Schema

```json
{
  "title": "Schema for CheckUserExistResponse",
  "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.CheckUserExistResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CheckUserExistResponse' to distinguish the command from others.",
      "type": "string"
    },
    "Exist": {
      "type": "bool"
    },
    "Command": {
      "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.CheckUserExistCommand",
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
}
```

### Example

```json
{
  "CommandName": "CheckUserExistResponse",
  "Exist": false,
  "Command": {
    "CommandName": "CheckUserExistCommand",
    "Username": null
  }
}
```

