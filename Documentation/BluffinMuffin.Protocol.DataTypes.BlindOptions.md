# BlindOptions

The type of blinds the table uses (none, blinds, antes)

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

An ante is a forced bet in which all players put an equal amount of money or chips into the pot before the deal begins. Often this is either a single unit (a one-value or the smallest value in play) or some other small amount; a proportion such as a half or a quarter of the minimum bet is also common. An ante paid by every player ensures that a player who folds every round will lose money (though slowly), thus providing all players with an incentive, however small, to play the hand rather than toss it in when the opening bet reaches them.

[More Info](http://en.wikipedia.org/wiki/Betting_in_poker#Ante)

### Command Schema

```json
{
  "title": "Schema for BlindOptionsAnte",
  "type": "BluffinMuffin.Protocol.DataTypes.BlindOptionsAnte",
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

### Example

```json
{
  "OptionType": "Antes",
  "MoneyUnit": 10
}
```

## BlindOptionsBlinds

A blind bet or just blind is a forced bet placed into the pot by one or more players before the deal begins, in a way that simulates bets made during play. The most common use of blinds as a betting structure calls for two blinds: the player after the dealer blinds about half of what would be a normal bet, and the next player blinds what would be a whole bet.

[More Info](http://en.wikipedia.org/wiki/Betting_in_poker#Blinds)

### Command Schema

```json
{
  "title": "Schema for BlindOptionsBlinds",
  "type": "BluffinMuffin.Protocol.DataTypes.BlindOptionsBlinds",
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

### Example

```json
{
  "OptionType": "Blinds",
  "MoneyUnit": 10
}
```

## BlindOptionsNone

With no blinds, the preflop round starts as avery other round, with no money on the Table.

### Command Schema

```json
{
  "title": "Schema for BlindOptionsNone",
  "type": "BluffinMuffin.Protocol.DataTypes.BlindOptionsNone",
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

### Example

```json
{
  "OptionType": "None",
  "MoneyUnit": 10
}
```

