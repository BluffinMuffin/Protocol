# BlindOptions

BluffinMuffin.Protocol.DataTypes.BlindOptions

### Command Schema

```json
{
  "title": "Schema for BlindOptions",
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
}
```

## BlindOptionsAnte

### Command Schema

```json
{
  "title": "Schema for BlindOptionsAnte",
  "type": "BluffinMuffin.Protocol.DataTypes.BlindOptionsAnte",
  "properties": {
    "AnteAmount": {
      "type": "int"
    },
    "MoneyUnit": {
      "type": "int"
    },
    "OptionType": {
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.BlindTypeEnum",
      "enum": [
        "Antes",
        "Blinds",
        "None"
      ]
    }
  }
}
```

### Example

```json
{
  "OptionType": "Antes",
  "AnteAmount": 10,
  "MoneyUnit": 10
}
```

## BlindOptionsBlinds

### Command Schema

```json
{
  "title": "Schema for BlindOptionsBlinds",
  "type": "BluffinMuffin.Protocol.DataTypes.BlindOptionsBlinds",
  "properties": {
    "BigBlindAmount": {
      "type": "int"
    },
    "MoneyUnit": {
      "type": "int"
    },
    "OptionType": {
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.BlindTypeEnum",
      "enum": [
        "Antes",
        "Blinds",
        "None"
      ]
    },
    "SmallBlindAmount": {
      "type": "int"
    }
  }
}
```

### Example

```json
{
  "OptionType": "Blinds",
  "BigBlindAmount": 10,
  "SmallBlindAmount": 5,
  "MoneyUnit": 10
}
```

## BlindOptionsNone

### Command Schema

```json
{
  "title": "Schema for BlindOptionsNone",
  "type": "BluffinMuffin.Protocol.DataTypes.BlindOptionsNone",
  "properties": {
    "MoneyUnit": {
      "type": "int"
    },
    "OptionType": {
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.BlindTypeEnum",
      "enum": [
        "Antes",
        "Blinds",
        "None"
      ]
    }
  }
}
```

### Example

```json
{
  "OptionType": "None",
  "MoneyUnit": 10
}
```

