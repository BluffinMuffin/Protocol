# Game : GameMessage

This command is there to inform players of something. This is for additionnal information, ignoring this message should not change anything to the game.

More information on ...

* [GameMessageOption](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.DataTypes.Options.GameMessageOption.md)

## GameMessageCommand

### Command Schema

```json
{
  "title": "Schema for GameMessageCommand",
  "type": "BluffinMuffin.Protocol.Game.GameMessageCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'GameMessageCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "Message": {
      "description": "The text message",
      "type": "string"
    },
    "Info": {
      "description": "The specific information of the message",
      "type": "BluffinMuffin.Protocol.DataTypes.Options.GameMessageOption",
      "properties": {
        "OptionType": {
          "description": "The type of message sent by the server",
          "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameMessageEnum",
          "enum": [
            "GeneralInformation",
            "RaisingCapped",
            "StudBringIn",
            "StudHighestHand",
            "PlayerJoined",
            "PlayerLeft"
          ]
        }
      }
    }
  }
}
```

### Example

```json
{
  "CommandName": "GameMessageCommand",
  "TableId": 42,
  "Message": "SpongeBob just joined the table",
  "Info": {
    "OptionType": "PlayerJoined",
    "PlayerName": "SpongeBob"
  }
}
```

