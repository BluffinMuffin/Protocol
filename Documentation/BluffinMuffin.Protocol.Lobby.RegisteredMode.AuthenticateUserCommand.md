# Lobby RegisteredMode : AuthenticateUser

This command will try to authenticate the client against the user database on the server.

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/BluffinMuffin.Protocol.Lobby.RegisteredMode.AuthenticateUserCommand.png" alt="Sequence Diagram"></p>

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/BluffinMuffin.Protocol.Lobby.RegisteredMode.AuthenticateUserCommand.png" alt="Activity Diagram"></p>

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
      "description": "The password associated with the username",
      "type": "string"
    },
    "Username": {
      "description": "The username",
      "type": "string"
    }
  }
}
```

### Example

```json
{
  "CommandName": "AuthenticateUserCommand",
  "Username": "ericmas001",
  "Password": "0nc3Up0nAT1m3"
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
    "Command": {
      "description": "The command who initiated this response",
      "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.AuthenticateUserCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'AuthenticateUserCommand' to distinguish the command from others.",
          "type": "string"
        },
        "Password": {
          "description": "The password associated with the username",
          "type": "string"
        },
        "Username": {
          "description": "The username",
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
  "Success": true,
  "MessageId": "None",
  "Message": "",
  "Command": {
    "CommandName": "AuthenticateUserCommand",
    "Username": "ericmas001",
    "Password": "0nc3Up0nAT1m3"
  }
}
```

