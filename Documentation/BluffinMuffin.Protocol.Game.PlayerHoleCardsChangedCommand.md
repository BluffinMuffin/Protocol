# Game : PlayerHoleCardsChanged

This command is send by the server to inform everybody that the cards of a player just changed.

This is used to inform a player of the cards he just got dealed, to inform other players that some cards has been dealt to a player, or to show cards to everybody at showdown.

## PlayerHoleCardsChangedCommand

### Command Schema

```json
{
  "title": "Schema for PlayerHoleCardsChangedCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerHoleCardsChangedCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerHoleCardsChangedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "FaceDownCards": {
      "description": "The cards in hand that are currently facing down (hidden to other players).",
      "type": "array",
      "items": {
        "type": "string"
      }
    },
    "FaceUpCards": {
      "description": "The cards in hand that are currently facing up (visible to other players).",
      "type": "array",
      "items": {
        "type": "string"
      }
    },
    "NoSeat": {
      "description": "The position on the table where is sitting the player with the cards.",
      "type": "int"
    },
    "PlayerState": {
      "description": "The state of the player.",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.PlayerStateEnum",
      "enum": [
        "None",
        "Joined",
        "SitIn",
        "AllIn",
        "Playing"
      ]
    }
  }
}
```

### Example

```json
{
  "CommandName": "PlayerHoleCardsChangedCommand",
  "TableId": 42,
  "NoSeat": 7,
  "FaceUpCards": [
    "2s",
    "Ah"
  ],
  "FaceDownCards": [
    "??",
    "??"
  ],
  "PlayerState": "Playing"
}
```

