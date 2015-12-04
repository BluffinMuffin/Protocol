# General : Disconnect

This command is sent to inform the other end of the Tcp Connection that the communication should end

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/BluffinMuffin.Protocol.DisconnectCommand.png" alt="Sequence Diagram"></p>

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/BluffinMuffin.Protocol.DisconnectCommand.png" alt="Activity Diagram"></p>

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

