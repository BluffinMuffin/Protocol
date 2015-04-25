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
        "IsEmpty": {
          "type": "bool"
        },
        "NoSeat": {
          "type": "int"
        },
        "Player": {
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
            "MoneyAmnt": {
              "description": "Current Money Amount of the player (Safe + Bet)",
              "type": "int"
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
        "SerializableAttributes": {
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
    "IsEmpty": false,
    "NoSeat": 0,
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
      "IsShowingCards": false,
      "MoneyAmnt": 1042
    },
    "SerializableAttributes": []
  },
  "TableId": 0
}
```

