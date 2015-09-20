# Game : PlayerTurnBegan

The server sends this command to indicated that it's time for a specific player to play.

## PlayerTurnBeganCommand

### Command Schema

```json
{
  "title": "Schema for PlayerTurnBeganCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerTurnBeganCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerTurnBeganCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "AmountNeeded": {
      "description": "The amount needed to call. It's the minimum to play if you don't want to fold.",
      "type": "int"
    },
    "CanFold": {
      "description": "Usually True. Indicates if the player have the option to Fold. It's false when it's the bring-in.",
      "type": "bool"
    },
    "MaximumRaiseAmount": {
      "description": "The maximum amount somebody can raise. Total, the player can put AmountNeeded+MaximumRaiseAmount. When No Maximum, this is set to int.MaxValue",
      "type": "int"
    },
    "MinimumRaiseAmount": {
      "description": "The minimum amount needed to raise. A raise must be at least the size of the largest previous bet or raise of the current betting round. To raise, the player have to send at least AmountNeeded+MinimumRaiseAmount.",
      "type": "int"
    },
    "NoSeat": {
      "description": "The position on the table where is sitting the player that needs to play",
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "PlayerTurnBeganCommand",
  "TableId": 42,
  "NoSeat": 7,
  "AmountNeeded": 21,
  "CanFold": true,
  "MinimumRaiseAmount": 42,
  "MaximumRaiseAmount": 4200
}
```

