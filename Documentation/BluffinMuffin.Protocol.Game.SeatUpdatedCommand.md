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
                      "None",
                      "Null",
                      "Hidden",
                      "JokerColor",
                      "JokerDark"
                    ]
                  },
                  "Value": {
                    "type": "Com.Ericmas001.Games.GameCardValue",
                    "enum": [
                      "Two",
                      "Three",
                      "Four",
                      "Five",
                      "Six",
                      "Seven",
                      "Eight",
                      "Nine",
                      "Ten",
                      "Jack",
                      "Queen",
                      "King",
                      "Ace"
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
                "Zombie",
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
              "CurrentPlayer"
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
  }
}
```

