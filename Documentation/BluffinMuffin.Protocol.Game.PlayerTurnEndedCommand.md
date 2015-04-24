# Game : PlayerTurnEnded

BluffinMuffin.Protocol.Game.PlayerTurnEndedCommand

## PlayerTurnEndedCommand

### Command Schema

```json
{
  "title": "Schema for PlayerTurnEndedCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerTurnEndedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "ActionAmount": {
      "type": "int"
    },
    "ActionType": {
      "type": "object",
      "properties": {}
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
      "type": "object",
      "properties": {}
    },
    "TableId": {
      "type": "int"
    },
    "TotalPot": {
      "type": "int"
    }
  }
}```

### Example

