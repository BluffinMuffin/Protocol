# Lobby RegisteredMode : CheckDisplayExist

BluffinMuffin.Protocol.Lobby.RegisteredMode.CheckDisplayExistCommand

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/BluffinMuffin.Protocol.Lobby.RegisteredMode.CheckDisplayExistCommand.png" alt="Sequence Diagram"></p>

## CheckDisplayExistCommand

### Command Schema

```json
{
  "title": "Schema for CheckDisplayExistCommand",
  "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.CheckDisplayExistCommand",
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

```json
{
  "CommandName": "CheckDisplayExistCommand",
  "DisplayName": null
}
```

## CheckDisplayExistResponse

### Command Schema

```json
{
  "title": "Schema for CheckDisplayExistResponse",
  "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.CheckDisplayExistResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CheckDisplayExistResponse' to distinguish the command from others.",
      "type": "string"
    },
    "Exist": {
      "type": "bool"
    },
    "Command": {
      "description": "The command who initiated this response",
      "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.CheckDisplayExistCommand",
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

```json
{
  "CommandName": "CheckDisplayExistResponse",
  "Exist": false,
  "Command": {
    "CommandName": "CheckDisplayExistCommand",
    "DisplayName": null
  }
}
```

