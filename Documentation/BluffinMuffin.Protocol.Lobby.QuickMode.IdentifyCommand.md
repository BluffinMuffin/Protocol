# Lobby QuickMode : Identify

In Quick mode, you must **identify** yourself. This action puts a unique name to your Tcp Connection for the server. This name will be used as your playername on every table that you will play.

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequence%20Diagrams/BluffinMuffin.Protocol.Lobby.QuickMode.IdentifyCommand.png" alt="Sequence Diagram"></p>

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
    "Ok": {
      "description": "Indicates if the identification was successful",
      "type": "bool"
    },
    "Command": {
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
  "Ok": true,
  "Command": {
    "CommandName": "IdentifyCommand",
    "Name": "SpongeBob"
  }
}
```

