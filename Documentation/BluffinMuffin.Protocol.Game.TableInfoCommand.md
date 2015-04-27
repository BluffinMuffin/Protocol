# Game : TableInfo

Sends all the information about the current state of the table, to put everybody on the same page.

## TableInfoCommand

### Command Schema

```json
{
  "title": "Schema for TableInfoCommand",
  "type": "BluffinMuffin.Protocol.Game.TableInfoCommand",
  "properties": {
    "CommandName": {
      "description": "Always contains 'TableInfoCommand' to distinguish the command from others.",
      "type": "string"
    },
    "BoardCardIDs": {
      "description": "All the card ids currently visible on the board (Preflop: empty, flop: 3 cars, turn: 4 cards, river: 5 cards)",
      "type": "array",
      "items": {
        "type": "int"
      }
    },
    "GameHasStarted": {
      "description": "Informs the client if the game is currently in the playing state, or not.",
      "type": "bool"
    },
    "Params": {
      "description": "Parameters of the poker table",
      "type": "BluffinMuffin.Protocol.DataTypes.TableParams",
      "properties": {
        "GameType": {
          "description": "The type of poker",
          "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameTypeEnum",
          "enum": [
            "Holdem"
          ]
        },
        "MaxPlayers": {
          "description": "The maximum number of players. (Between 2 and 10, and must be >= MinPlayersToStart)",
          "type": "int"
        },
        "MinPlayersToStart": {
          "description": "The minimum seated players needed to start the game. (Between 2 and 10)",
          "type": "int"
        },
        "MoneyUnit": {
          "description": "The unit used by the table. This unit is usually the big blind, the minimum raise, etc.",
          "type": "int"
        },
        "TableName": {
          "description": "The name of the table",
          "type": "string"
        },
        "Variant": {
          "description": "The variant of the GameType",
          "type": "string"
        },
        "WaitingTimes": {
          "description": "The waiting times (At different stage of the game, the server will wait before continuing to making it feel real !)",
          "type": "BluffinMuffin.Protocol.DataTypes.ConfigurableWaitingTimes",
          "properties": {
            "AfterBoardDealed": {
              "description": "Amount of miliseconds (ms) to wait after cards are dealed",
              "type": "int"
            },
            "AfterPlayerAction": {
              "description": "Amount of miliseconds (ms) to wait after a player do something.",
              "type": "int"
            },
            "AfterPotWon": {
              "description": "Amount of miliseconds (ms) to wait after pot is won",
              "type": "int"
            }
          }
        },
        "Blind": {
          "description": "The type of blinds the table uses (none, blinds, antes) See 'BluffinMuffin.Protocol.DataTypes.BlindOptions' for more details",
          "type": "BluffinMuffin.Protocol.DataTypes.BlindOptions",
          "properties": {
            "MoneyUnit": {
              "description": "The Money unit. Should always be equal to the moneyUnit of the table.",
              "type": "int"
            },
            "OptionType": {
              "description": "The type of blinds used for the table",
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.BlindTypeEnum",
              "enum": [
                "Antes",
                "Blinds",
                "None"
              ]
            }
          }
        },
        "Limit": {
          "description": "The type of limit the table uses (NoLimit, PotLimit, FixedLimit) See 'BluffinMuffin.Protocol.DataTypes.LimitOptions' for more details",
          "type": "BluffinMuffin.Protocol.DataTypes.LimitOptions",
          "properties": {
            "OptionType": {
              "description": "The type of limit you want to apply on raises",
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum",
              "enum": [
                "FixedLimit",
                "NoLimit",
                "PotLimit"
              ]
            }
          }
        },
        "Lobby": {
          "description": "The type of table it is (QuickMode ? RegisteredMode ?) See 'BluffinMuffin.Protocol.DataTypes.LobbyOptions' for more details",
          "type": "BluffinMuffin.Protocol.DataTypes.LobbyOptions",
          "properties": {
            "OptionType": {
              "description": "What type of lobby it is",
              "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyTypeEnum",
              "enum": [
                "QuickMode",
                "RegisteredMode"
              ]
            }
          }
        }
      }
    },
    "PotsAmount": {
      "description": "All the pots on the table. Usually only one, but can have more if some players are all-in.",
      "type": "array",
      "items": {
        "type": "int"
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
      }
    },
    "TableId": {
      "description": "The id of the table where this command needs to go",
      "type": "int"
    },
    "TotalPotAmount": {
      "description": "The total amount of money currently played in this game. This include the money in the center, and the money played in front of each player.",
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "CommandName": "TableInfoCommand",
  "Params": {
    "TableName": "Bikini Bottom",
    "GameType": "Holdem",
    "Variant": "Texas Hold'em",
    "MinPlayersToStart": 2,
    "MaxPlayers": 10,
    "WaitingTimes": {
      "AfterPlayerAction": 500,
      "AfterBoardDealed": 500,
      "AfterPotWon": 2500
    },
    "MoneyUnit": 10,
    "Lobby": {
      "OptionType": "QuickMode",
      "StartingAmount": 1500
    },
    "Blind": {
      "OptionType": "Blinds",
      "MoneyUnit": 0
    },
    "Limit": {
      "OptionType": "NoLimit"
    }
  },
  "TotalPotAmount": 42000,
  "PotsAmount": [
    4200,
    420
  ],
  "BoardCardIDs": [
    21,
    42,
    7
  ],
  "Seats": null,
  "GameHasStarted": true,
  "TableId": 42
}
```

