# General : Disconnect

BluffinMuffin.Protocol.DisconnectCommand

## DisconnectCommand

### Command Schema

```json
{
  "title": "Schema for DisconnectCommand",
  "type": "BluffinMuffin.Protocol.DisconnectCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'DisconnectCommand' to distinguish the command from others.",
      "type": "string"
    }
  }
}
```

### Example

```json
{
  "CommandName": "DisconnectCommand"
}
```

