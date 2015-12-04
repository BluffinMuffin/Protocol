# Lobby RegisteredMode : CreateUser

This commands will create a new user in the database.

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/BluffinMuffin.Protocol.Lobby.RegisteredMode.CreateUserCommand.png" alt="Sequence Diagram"></p>

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/BluffinMuffin.Protocol.Lobby.RegisteredMode.CreateUserCommand.png" alt="Activity Diagram"></p>

## CreateUserCommand

### Command Schema

```json
{
  "title": "Schema for CreateUserCommand",
  "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.CreateUserCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CreateUserCommand' to distinguish the command from others.",
      "type": "string"
    },
    "DisplayName": {
      "description": "The display name you want for this user",
      "type": "string"
    },
    "Email": {
      "description": "An email address to reach this user",
      "type": "string"
    },
    "Password": {
      "description": "The password you want to use",
      "type": "string"
    },
    "Username": {
      "description": "The username you want to have",
      "type": "string"
    }
  }
}
```

### Example

```json
{
  "CommandName": "CreateUserCommand",
  "Username": "ericmas001",
  "Password": "0nc3Up0nAT1m3",
  "Email": "ericmas001@hotmail.com",
  "DisplayName": "Sponge Bob"
}
```

## CreateUserResponse

### Command Schema

```json
{
  "title": "Schema for CreateUserResponse",
  "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.CreateUserResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'CreateUserResponse' to distinguish the command from others.",
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
      "type": "BluffinMuffin.Protocol.Lobby.RegisteredMode.CreateUserCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'CreateUserCommand' to distinguish the command from others.",
          "type": "string"
        },
        "DisplayName": {
          "description": "The display name you want for this user",
          "type": "string"
        },
        "Email": {
          "description": "An email address to reach this user",
          "type": "string"
        },
        "Password": {
          "description": "The password you want to use",
          "type": "string"
        },
        "Username": {
          "description": "The username you want to have",
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
  "CommandName": "CreateUserResponse",
  "Success": true,
  "MessageId": "None",
  "Message": "",
  "Command": {
    "CommandName": "CreateUserCommand",
    "Username": "ericmas001",
    "Password": "0nc3Up0nAT1m3",
    "Email": "ericmas001@hotmail.com",
    "DisplayName": "Sponge Bob"
  }
}
```

