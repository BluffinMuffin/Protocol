# Game : PlayerTurnEnded

BluffinMuffin.Protocol.Game.PlayerTurnEndedCommand

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
      "type": "int"
    },
    "ActionType": {
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
      "type": "int"
    },
    "PlayerMoney": {
      "type": "int"
    },
    "PlayerPos": {
      "type": "int"
    },
    "State": {
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
      "type": "int"
    },
    "TotalPot": {
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "PlayerTurnEndedCommand",
  "PlayerPos": 0,
  "PlayerBet": 0,
  "PlayerMoney": 0,
  "TotalPot": 0,
  "ActionType": "Fold",
  "ActionAmount": 0,
  "State": "Zombie",
  "TableId": 0
}
```

