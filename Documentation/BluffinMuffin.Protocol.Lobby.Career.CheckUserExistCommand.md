# Lobby Career : CheckUserExist

BluffinMuffin.Protocol.Lobby.Career.CheckUserExistCommand

## CheckUserExistCommand

### Command Schema

```json
{
  "title": "Schema for CheckUserExistCommand",
  "type": "BluffinMuffin.Protocol.Lobby.Career.CheckUserExistCommand",
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

## CheckUserExistResponse

### Command Schema

```json
{
  "title": "Schema for CheckUserExistResponse",
  "type": "BluffinMuffin.Protocol.Lobby.Career.CheckUserExistResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CheckUserExistResponse' to distinguish the command from others.",
      "type": "string"
    },
    "Exist": {
      "type": "bool"
    },
    "Command": {
      "type": "BluffinMuffin.Protocol.Lobby.Career.CheckUserExistCommand",
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

