# Lobby RegisteredMode : CheckDisplayExist

In the User Creation Process, it's useful to check if the display name is already taken. You can then validate the display name before actually creating the user. (Display name is the name viewed by other players on the table)

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/BluffinMuffin.Protocol.Lobby.RegisteredMode.CheckDisplayExistCommand.png" alt="Sequence Diagram"></p>

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/BluffinMuffin.Protocol.Lobby.RegisteredMode.CheckDisplayExistCommand.png" alt="Activity Diagram"></p>

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
      "description": "The display name you want to check the existance of",
      "type": "string"
    }
  }
}
```

### Example

```json
{
  "CommandName": "CheckDisplayExistCommand",
  "DisplayName": "Sponge Bob"
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
      "description": "true if the display name exists",
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
          "description": "The display name you want to check the existance of",
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
  "Exist": true,
  "Command": {
    "CommandName": "CheckDisplayExistCommand",
    "DisplayName": "Sponge Bob"
  }
}
```

