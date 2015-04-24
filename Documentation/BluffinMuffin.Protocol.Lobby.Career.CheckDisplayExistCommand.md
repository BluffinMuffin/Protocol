# Lobby Career : CheckDisplayExist

BluffinMuffin.Protocol.Lobby.Career.CheckDisplayExistCommand

## CheckDisplayExistCommand

### Command Schema

```json
{
  "title": "Schema for CheckDisplayExistCommand",
  "type": "BluffinMuffin.Protocol.Lobby.Career.CheckDisplayExistCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CheckDisplayExistCommand' to distinguish the command from others.",
      "type": "string"
    },
    "DisplayName": {
      "type": "string"
    }
  }
}
```

### Example

## CheckDisplayExistResponse

### Command Schema

```json
{
  "title": "Schema for CheckDisplayExistResponse",
  "type": "BluffinMuffin.Protocol.Lobby.Career.CheckDisplayExistResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CheckDisplayExistResponse' to distinguish the command from others.",
      "type": "string"
    },
    "Exist": {
      "type": "bool"
    },
    "Command": {
      "type": "BluffinMuffin.Protocol.Lobby.Career.CheckDisplayExistCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'CheckDisplayExistCommand' to distinguish the command from others.",
          "type": "string"
        },
        "DisplayName": {
          "type": "string"
        }
      }
    }
  }
}
```

### Example

