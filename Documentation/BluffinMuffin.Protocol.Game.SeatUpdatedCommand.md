# Game : SeatUpdated

BluffinMuffin.Protocol.Game.SeatUpdatedCommand

## SeatUpdatedCommand

### Command Schema

```json
{
  "title": "Schema for SeatUpdatedCommand",
  "type": "object",
  "properties": {
    "CommandName": {
      "description": "Always contains 'SeatUpdatedCommand' to distinguish the command from others.",
      "type": "string"
    },
    "Seat": {
      "type": "object",
      "properties": {
        "IsEmpty": {
          "type": "bool"
        },
        "NoSeat": {
          "type": "int"
        },
        "Player": {
          "type": "object",
          "properties": {
            "HoleCards": {
              "type": "object",
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
                  "type": "object",
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
              "type": "object",
              "properties": {}
            }
          }
        },
        "SerializableAttributes": {
          "type": "object",
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
              "type": "object",
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
}```

### Example

