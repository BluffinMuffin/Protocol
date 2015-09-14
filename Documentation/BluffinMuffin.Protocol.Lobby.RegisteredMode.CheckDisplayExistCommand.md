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
    "Success": {
      "description": "True if the command was a success",
      "type": "bool"
    },
    "MessageId": {
      "description": "The Id of the message. None if no message",
      "type": "BluffinMuffin.Protocol.Enums.BluffinMessageId",
      "enum": [
        "None",
        "SpecificServerMessage",
        "WrongTableState",
        "NameAlreadyUsed",
        "UsernameAlreadyUsed",
        "UsernameNotFound",
        "InvalidPassword",
        "InvalidEmail",
        "SeatChanged",
        "NoMoreSeats",
        "NotAuthenticated",
        "WrongLobbyType",
        "NotSupported"
      ]
    },
    "Message": {
      "description": "The message. Empty if no messages",
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
  "Success": true,
  "MessageId": "None",
  "Message": "",
  "Exist": true,
  "Command": {
    "CommandName": "CheckDisplayExistCommand",
    "DisplayName": "Sponge Bob"
  }
}
```

