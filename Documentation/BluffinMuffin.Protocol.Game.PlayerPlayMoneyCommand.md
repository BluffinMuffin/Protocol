# Game : PlayerPlayMoney

The client is telling the server that he plays some money.

## PlayerPlayMoneyCommand

### Command Schema

```json
{
  "title": "Schema for PlayerPlayMoneyCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerPlayMoneyCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerPlayMoneyCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "AmountPlayed": {
      "description": "Amount of money played",
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "PlayerPlayMoneyCommand",
  "TableId": 42,
  "AmountPlayed": 42
}
```

