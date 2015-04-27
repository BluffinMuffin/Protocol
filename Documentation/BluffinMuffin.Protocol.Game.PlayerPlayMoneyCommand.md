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
    "Played": {
      "description": "Amount of money played",
      "type": "int"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "PlayerPlayMoneyCommand",
  "Played": 42,
  "TableId": 42
}
```

