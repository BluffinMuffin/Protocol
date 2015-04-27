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
    "ActionAmount": {
      "description": "The amount of money that the player has put for this single action",
      "type": "int"
    },
    "ActionType": {
      "description": "The type of action that was taken by the player",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameActionEnum",
      "enum": [
        "Call",
        "DoNothing",
        "Fold",
        "PostAnte",
        "PostBigBlind",
        "PostSmallBlind",
        "Raise"
      ]
    },
    "PlayerBet": {
      "description": "The total amount of money a player have bet since the beginning of the round.",
      "type": "int"
    },
    "PlayerMoney": {
      "description": "The total amount of money a player have that has not been played.",
      "type": "int"
    },
    "PlayerPos": {
      "description": "The position on the table where is sitting the player that needs to play",
      "type": "int"
    },
    "State": {
      "description": "The current state of the player that just played",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.PlayerStateEnum",
      "enum": [
        "AllIn",
        "Joined",
        "Playing",
        "SitIn",
        "Zombie"
      ]
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "TotalPot": {
      "description": "The total amount of money currently played in this game. This include the money in the center, and the money played in front of each player.",
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "PlayerTurnEndedCommand",
  "PlayerPos": 7,
  "PlayerBet": 420,
  "PlayerMoney": 4200,
  "TotalPot": 42000,
  "ActionType": "Call",
  "ActionAmount": 42,
  "State": "Playing",
  "TableId": 42
}
```

