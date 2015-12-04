# Lobby QuickMode : Identify

In Quick mode, you must **identify** yourself. This action puts a unique name to your Tcp Connection for the server. This name will be used as your playername on every table that you will play.

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/BluffinMuffin.Protocol.Lobby.QuickMode.IdentifyCommand.png" alt="Sequence Diagram"></p>

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/BluffinMuffin.Protocol.Lobby.QuickMode.IdentifyCommand.png" alt="Activity Diagram"></p>

## IdentifyCommand

### Command Schema

```json
{
  "title": "Schema for IdentifyCommand",
  "type": "BluffinMuffin.Protocol.Lobby.QuickMode.IdentifyCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'IdentifyCommand' to distinguish the command from others.",
      "type": "string"
    },
    "Name": {
      "description": "The name you want to have on the server !",
      "type": "string"
    }
  }
}
```

### Example

```json
{
  "CommandName": "IdentifyCommand",
  "Name": "SpongeBob"
}
```

## IdentifyResponse

### Command Schema

```json
{
  "title": "Schema for IdentifyResponse",
  "type": "BluffinMuffin.Protocol.Lobby.QuickMode.IdentifyResponse",
  "properties": {
    "CommandName": {
      "description": "Always contains 'IdentifyResponse' to distinguish the command from others.",
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
      "type": "BluffinMuffin.Protocol.Lobby.QuickMode.IdentifyCommand",
      "properties": {
        "CommandName": {
          "description": "Always contains 'IdentifyCommand' to distinguish the command from others.",
          "type": "string"
        },
        "Name": {
          "description": "The name you want to have on the server !",
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
  "CommandName": "IdentifyResponse",
  "Success": true,
  "MessageId": "None",
  "Message": "",
  "Command": {
    "CommandName": "IdentifyCommand",
    "Name": "SpongeBob"
  }
}
```

