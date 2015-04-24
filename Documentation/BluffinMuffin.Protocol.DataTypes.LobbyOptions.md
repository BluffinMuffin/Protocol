# LobbyOptions

BluffinMuffin.Protocol.DataTypes.LobbyOptions

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

### Command Schema

```json
{
  "title": "Schema for LobbyOptionsCareer",
  "type": "BluffinMuffin.Protocol.DataTypes.LobbyOptionsCareer",
  "properties": {
    "IsMaximumBuyInLimited": {
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
  "IsMaximumBuyInLimited": false
}
```

## LobbyOptionsTraining

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

