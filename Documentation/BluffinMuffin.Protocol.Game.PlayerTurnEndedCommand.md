# Game : PlayerTurnEnded

Server informs all the clients that a player has taken action.

## PlayerTurnEndedCommand

### Command Schema

```json
{
  "title": "Schema for PlayerTurnEndedCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerTurnEndedCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerTurnEndedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "ActionTakenAmount": {
      "description": "The amount of money that the player has put for this single action",
      "type": "int"
    },
    "ActionTakenType": {
      "description": "The type of action that was taken by the player",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameActionEnum",
      "enum": [
        "Fold",
        "Call",
        "Raise",
        "PostSmallBlind",
        "PostBigBlind",
        "PostAnte",
        "PostBringIn",
        "DoNothing"
      ]
    },
    "NoSeat": {
      "description": "The position on the table where is sitting the player that needs to play",
      "type": "int"
    },
    "PlayerState": {
      "description": "The current state of the player that just played",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.PlayerStateEnum",
      "enum": [
        "None",
        "Joined",
        "SitIn",
        "AllIn",
        "Playing"
      ]
    },
    "TotalPlayedMoneyAmount": {
      "description": "The total amount of money a player have bet since the beginning of the round.",
      "type": "int"
    },
    "TotalPot": {
      "description": "The total amount of money currently played in this game. This include the money in the center, and the money played in front of each player.",
      "type": "int"
    },
    "TotalSafeMoneyAmount": {
      "description": "The total amount of money a player have that has not been played.",
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "PlayerTurnEndedCommand",
  "TableId": 42,
  "NoSeat": 7,
  "TotalPlayedMoneyAmount": 420,
  "TotalSafeMoneyAmount": 4200,
  "TotalPot": 42000,
  "ActionTakenType": "Call",
  "ActionTakenAmount": 42,
  "PlayerState": "Playing"
}
```

