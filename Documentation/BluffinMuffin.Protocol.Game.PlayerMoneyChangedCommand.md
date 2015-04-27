# Game : PlayerMoneyChanged

The server is sharing new information about the money in the pockets of a player.

## PlayerMoneyChangedCommand

### Command Schema

```json
{
  "title": "Schema for PlayerMoneyChangedCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerMoneyChangedCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerMoneyChangedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "PlayerMoney": {
      "description": "The unplayed amount of money that the player have.",
      "type": "int"
    },
    "PlayerPos": {
      "description": "The position on the table where is sitting the player.",
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
  "CommandName": "PlayerMoneyChangedCommand",
  "PlayerPos": 7,
  "PlayerMoney": 4200,
  "TableId": 42
}
```

