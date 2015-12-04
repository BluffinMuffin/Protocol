# Game : SeatUpdated

Server informs clients that a seat has changed state. Usually sent when player sits-in or sits-out.

## SeatUpdatedCommand

### Command Schema

```json
{
  "title": "Schema for SeatUpdatedCommand",
  "type": "BluffinMuffin.Protocol.Game.SeatUpdatedCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'SeatUpdatedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "Seat": {
      "description": "The seat that has changed state",
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
```

### Example

```json
{
  "CommandName": "SeatUpdatedCommand",
  "TableId": 42,
  "Seat": {
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
}
```

