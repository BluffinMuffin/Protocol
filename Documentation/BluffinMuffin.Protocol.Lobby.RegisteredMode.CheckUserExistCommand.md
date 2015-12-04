# Lobby RegisteredMode : CheckUserExist

In the User Creation Process, it's useful to check if the username is already taken. You can then validate the username before actually creating the user. (Username is the name used to connect)

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/BluffinMuffin.Protocol.Lobby.RegisteredMode.CheckUserExistCommand.png" alt="Sequence Diagram"></p>

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/BluffinMuffin.Protocol.Lobby.RegisteredMode.CheckUserExistCommand.png" alt="Activity Diagram"></p>

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
      "description": "The display name you want to check the existance of",
      "type": "string"
    }
  }
}
```

### Example

```json
{
  "CommandName": "CheckUserExistCommand",
  "Username": "ericmas001"
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
      "description": "true if the username exists",
      "type": "bool"
    },
    "Command": {
      "description": "The command who initiated this response",
      "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.CheckUserExistCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'CheckUserExistCommand' to distinguish the command from others.",
          "type": "string"
        },
        "Username": {
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
  "CommandName": "CheckUserExistResponse",
  "Success": true,
  "MessageId": "None",
  "Message": "",
  "Exist": true,
  "Command": {
    "CommandName": "CheckUserExistCommand",
    "Username": "ericmas001"
  }
}
```

