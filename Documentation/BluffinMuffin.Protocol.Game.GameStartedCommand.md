# Game : GameStarted

This command is sent at the start of every game.

It's important to understand that a *game* is only one iteration. It's starts with blinds, then preflop, then ends when the pot is won. The next iteration will be a new *game*.

## GameStartedCommand

### Command Schema

```json
{
  "title": "Schema for GameStartedCommand",
  "type": "BluffinMuffin.Protocol.Game.GameStartedCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'GameStartedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "NeededBlindAmount": {
      "description": "The amount needed for this player as blinds. If the player doesn't need to put any blinds, he will receive 0",
      "type": "int"
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
  "CommandName": "GameStartedCommand",
  "TableId": 42,
  "NeededBlindAmount": 10,
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

