# Game : PlayerWonPot

This command is sent after the showdown to inform clients that some money has been won by some player

## PlayerWonPotCommand

### Command Schema

```json
{
  "title": "Schema for PlayerWonPotCommand",
  "type": "BluffinMuffin.Protocol.Game.PlayerWonPotCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'PlayerWonPotCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "NoSeat": {
      "description": "The position on the table where is sitting the player that won something",
      "type": "int"
    },
    "PotId": {
      "description": "The Id of the pot that was won by the player",
      "type": "int"
    },
    "TotalPlayerMoney": {
      "description": "The total amount of money in the pockets of the player after winning this money",
      "type": "int"
    },
    "TotalPotAmount": {
      "description": "The amount of money that was in the pot. Bigger than \"WonAmount\" if the pot was splitted.",
      "type": "int"
    },
    "WinningCards": {
      "description": "The cards that are responsible for winning the pot",
      "type": "array",
      "items": {
        "type": "string"
      }
    },
    "WinningHand": {
      "description": "The hand that is responsible for winning the pot",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.PokerHandEnum",
      "enum": [
        "None",
        "HighCard",
        "OnePair",
        "TwoPairs",
        "ThreeOfAKind",
        "Straight",
        "Flush",
        "FullHouse",
        "FourOfAKind",
        "StraightFlush"
      ]
    },
    "WonAmount": {
      "description": "The amount of money that was won by the player (Could be a fraction of the pot if there was a split.",
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "PlayerWonPotCommand",
  "TableId": 42,
  "NoSeat": 7,
  "PotId": 0,
  "WonAmount": 420,
  "TotalPotAmount": 1000,
  "TotalPlayerMoney": 4200,
  "WinningCards": [
    "5s",
    "5c",
    "5d",
    "Ad",
    "Ks"
  ],
  "WinningHand": "ThreeOfAKind"
}
```

