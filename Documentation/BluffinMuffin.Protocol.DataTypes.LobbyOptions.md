# LobbyOptions

The type of table it is (Training ? Career ?)

### Command Schema

```json
{
  "title": "Schema for LobbyOptions",
  "type": "BluffinMuffin.Protocol.DataTypes.LobbyOptions",
  "properties": {
    "OptionType": {
      "description": "What type of lobby it is",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyTypeEnum",
      "enum": [
        "Career",
        "Training"
      ]
    }
  }
}
```

## LobbyOptionsCareer

The career mode is a mode where a player connects with an account. He then have some money, that he uses throughout different games. When entering a game, he will take some of that money to play, and when he leaves what was left of that money will be given back to him.

### Command Schema

```json
{
  "title": "Schema for LobbyOptionsCareer",
  "type": "BluffinMuffin.Protocol.DataTypes.LobbyOptionsCareer",
  "properties": {
    "IsMaximumBuyInLimited": {
      "description": "If Limited, the maximum buy-in will be 100*MoneyUnit. If not, a player can sit with all his money if he wants.",
      "type": "bool"
    },
    "MoneyUnit": {
      "description": "The Money unit. Should always be equal to the moneyUnit of the table.",
      "type": "int"
    },
    "OptionType": {
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyTypeEnum",
      "enum": [
        "Career",
        "Training"
      ]
    }
  }
}
```

### Example

```json
{
  "OptionType": "Career",
  "MoneyUnit": 10,
  "IsMaximumBuyInLimited": true
}
```

## LobbyOptionsTraining

The training mode is a mode where the money is given to the player when he enters the table. For example, If the amount is set to 1500 on Table1, every player will receive 1500$ to play with when they will enter the Table.

### Command Schema

```json
{
  "title": "Schema for LobbyOptionsTraining",
  "type": "BluffinMuffin.Protocol.DataTypes.LobbyOptionsTraining",
  "properties": {
    "OptionType": {
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyTypeEnum",
      "enum": [
        "Career",
        "Training"
      ]
    },
    "StartingAmount": {
      "description": "The amount of money that will be given to every player that sits in.",
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "OptionType": "Training",
  "StartingAmount": 1500
}
```

