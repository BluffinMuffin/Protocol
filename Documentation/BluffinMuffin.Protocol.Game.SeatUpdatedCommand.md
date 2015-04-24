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
              "type": "Com.Ericmas001.Games.GameCard[]",
              "properties": {
                "IsFixedSize": {
                  "type": "bool"
                },
                "IsReadOnly": {
                  "type": "bool"
                },
                "IsSynchronized": {
                  "type": "bool"
                },
                "Length": {
                  "type": "int"
                },
                "LongLength": {
                  "type": "long"
                },
                "Rank": {
                  "type": "int"
                },
                "SyncRoot": {
                  "type": "System.Object",
                  "properties": {}
                }
              }
            },
            "IsShowingCards": {
              "type": "bool"
            },
            "MoneyAmnt": {
              "type": "int"
            },
            "MoneyBetAmnt": {
              "type": "int"
            },
            "MoneySafeAmnt": {
              "type": "int"
            },
            "Name": {
              "type": "string"
            },
            "NoSeat": {
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
          "type": "BluffinMuffin.Protocol.DataTypes.Enums.SeatAttributeEnum[]",
          "properties": {
            "IsFixedSize": {
              "type": "bool"
            },
            "IsReadOnly": {
              "type": "bool"
            },
            "IsSynchronized": {
              "type": "bool"
            },
            "Length": {
              "type": "int"
            },
            "LongLength": {
              "type": "long"
            },
            "Rank": {
              "type": "int"
            },
            "SyncRoot": {
              "type": "System.Object",
              "properties": {}
            }
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
      "NoSeat": -1,
      "Name": "Anonymous Player",
      "MoneySafeAmnt": 0,
      "MoneyBetAmnt": 0,
      "HoleCards": [
        {
          "Special": "Null",
          "Kind": "Club",
          "Value": "Two",
          "Id": -1
        },
        {
          "Special": "Null",
          "Kind": "Club",
          "Value": "Two",
          "Id": -1
        }
      ],
      "State": "Zombie",
      "IsShowingCards": false,
      "MoneyAmnt": 0
    },
    "SerializableAttributes": []
  },
  "TableId": 0
}
```

