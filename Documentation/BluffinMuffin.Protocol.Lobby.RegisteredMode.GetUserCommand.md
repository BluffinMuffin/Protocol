# Lobby RegisteredMode : GetUser

This command will Get the information about a player. This information should be only for the player itself.

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/BluffinMuffin.Protocol.Lobby.RegisteredMode.GetUserCommand.png" alt="Sequence Diagram"></p>

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/BluffinMuffin.Protocol.Lobby.RegisteredMode.GetUserCommand.png" alt="Activity Diagram"></p>

## GetUserCommand

### Command Schema

```json
{
  "title": "Schema for GetUserCommand",
  "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.GetUserCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'GetUserCommand' to distinguish the command from others.",
      "type": "string"
    }
  }
}
```

### Example

```json
{
  "CommandName": "GetUserCommand"
}
```

## GetUserResponse

### Command Schema

```json
{
  "title": "Schema for GetUserResponse",
  "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.GetUserResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'GetUserResponse' to distinguish the command from others.",
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
    "DisplayName": {
      "description": "The display name of the user",
      "type": "string"
    },
    "Email": {
      "description": "The email of the user",
      "type": "string"
    },
    "Money": {
      "description": "The money currently in bank for this user",
      "type": "double"
    },
    "Command": {
      "description": "The command who initiated this response",
      "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.GetUserCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'GetUserCommand' to distinguish the command from others.",
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
  "Success": true,
  "MessageId": "None",
  "Message": "",
  "Email": "ericmas001@hotmail.com",
  "DisplayName": "Sponge Bob",
  "Money": 42000.42,
  "Command": {
    "CommandName": "GetUserCommand"
  }
}
```

