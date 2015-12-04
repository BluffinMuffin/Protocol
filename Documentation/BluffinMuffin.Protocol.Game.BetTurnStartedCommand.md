# Game : BetTurnStarted

This command is issued by the server when a betting round is starting. For example, when the 3 first cards are shown, it's the beginning of the flop.

## BetTurnStartedCommand

### Command Schema

```json
{
  "title": "Schema for BetTurnStartedCommand",
  "type": "BluffinMuffin.Protocol.Game.BetTurnStartedCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'BetTurnStartedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "BettingRoundId": {
      "description": "The id of the betting round that is starting, starting at 1. For texas hold'em, Preflop=1, Flop=2, Turn=3, River=4",
      "type": "int"
    },
    "Cards": {
      "description": "All the card ids currently visible on the board (Preflop: empty, flop: 3 cards, turn: 4 cards, river: 5 cards)",
      "type": "array",
      "items": {
        "type": "string"
      }
    },
    "Seats": {
      "description": "The information about every seats around the table",
      "type": "array",
      "items": {
        "type": "BluffinMuffin.Protocol.DataTypes.SeatInfo",
        "properties": {
          "NoSeat": {
            "description": "The id of the current seat",
            "type": "int"
          },
          "Player": {
            "description": "The information of the player sitting in this seat. If null, there is nobody.",
            "type": "BluffinMuffin.Protocol.DataTypes.PlayerInfo",
            "properties": {
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
              "MoneyBetAmnt": {
                "description": "Current Money Amount of the player that he played this round",
                "type": "int"
              },
              "MoneySafeAmnt": {
                "description": "Current Money Amount of the player that he isn't playing with",
                "type": "int"
              },
              "Name": {
                "description": "The name of the player",
                "type": "string"
              },
              "NoSeat": {
                "description": "The seat used by the player",
                "type": "int"
              },
              "State": {
                "description": "Current state of the player",
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
          },
          "SeatAttributes": {
            "description": "The attributes of the seat",
            "type": "array",
            "items": {
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.SeatAttributeEnum",
              "enum": [
                "Dealer",
                "SmallBlind",
                "BigBlind",
                "CurrentPlayer",
                "FirstTalker"
              ]
            }
          }
        }
      }
    }
  }
}
```

### Example

```json
{
  "CommandName": "BetTurnStartedCommand",
  "TableId": 42,
  "BettingRoundId": 1,
  "Cards": [
    "2s",
    "Kh",
    "5d"
  ],
  "Seats": [
    {
      "NoSeat": 7,
      "Player": {
        "NoSeat": 7,
        "Name": "SpongeBob",
        "MoneySafeAmnt": 1000,
        "MoneyBetAmnt": 42,
        "FaceUpCards": [
          "2s",
          "Ah"
        ],
        "FaceDownCards": [
          "??",
          "??"
        ],
        "State": "Playing"
      },
      "SeatAttributes": [
        "CurrentPlayer",
        "BigBlind"
      ]
    }
  ]
}
```

