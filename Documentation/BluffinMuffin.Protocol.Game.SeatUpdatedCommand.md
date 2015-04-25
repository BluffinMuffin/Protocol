# Game : SeatUpdated

BluffinMuffin.Protocol.Game.SeatUpdatedCommand

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
    "Seat": {
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
            "HoleCards": {
              "description": "The cards in the hands of the player",
              "type": "array",
              "items": {
                "type": "Com.Ericmas001.Games.GameCard",
                "properties": {
                  "Kind": {
                    "type": "Com.Ericmas001.Games.GameCardKind",
                    "enum": [
                      "Club",
                      "Diamond",
                      "Heart",
                      "Spade"
                    ]
                  },
                  "Special": {
                    "type": "Com.Ericmas001.Games.GameCardSpecial",
                    "enum": [
                      "Hidden",
                      "JokerColor",
                      "JokerDark",
                      "None",
                      "Null"
                    ]
                  },
                  "Value": {
                    "type": "Com.Ericmas001.Games.GameCardValue",
                    "enum": [
                      "Ace",
                      "Eight",
                      "Five",
                      "Four",
                      "Jack",
                      "King",
                      "Nine",
                      "Queen",
                      "Seven",
                      "Six",
                      "Ten",
                      "Three",
                      "Two"
                    ]
                  }
                }
              }
            },
            "IsShowingCards": {
              "description": "true if the player cards are public (ex: during showdown)",
              "type": "bool"
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
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.PlayerStateEnum",
              "enum": [
                "AllIn",
                "Joined",
                "Playing",
                "SitIn",
                "Zombie"
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
              "BigBlind",
              "CurrentPlayer",
              "Dealer",
              "SmallBlind"
            ]
          }
        }
      }
    },
    "TableId": {
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "SeatUpdatedCommand",
  "Seat": {
    "NoSeat": 7,
    "Player": {
      "NoSeat": 7,
      "Name": "SpongeBob",
      "MoneySafeAmnt": 1000,
      "MoneyBetAmnt": 42,
      "HoleCards": [
        {
          "Special": "None",
          "Kind": "Spade",
          "Value": "Two"
        },
        {
          "Special": "None",
          "Kind": "Heart",
          "Value": "Ace"
        }
      ],
      "State": "Zombie",
      "IsShowingCards": false
    },
    "SeatAttributes": [
      "BigBlind",
      "CurrentPlayer"
    ]
  },
  "TableId": 0
}
```

