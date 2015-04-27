# LimitOptions

The type of limit the table uses (NoLimit, PotLimit, FixedLimit)

### Command Schema

```json
{
  "title": "Schema for LimitOptions",
  "type": "BluffinMuffin.Protocol.DataTypes.LimitOptions",
  "properties": {
    "OptionType": {
      "description": "The type of limit you want to apply on raises",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum",
      "enum": [
        "NoLimit",
        "FixedLimit",
        "PotLimit"
      ]
    }
  }
}
```

## LimitOptionsFixed

In a game played with a fixed-limit betting structure, a player chooses only whether to bet or not - the amount is fixed by rule. To enable the possibility of bluffing and protection, the fixed amount generally doubles at some point in the game. This double wager amount is referred to as a big bet.

[More Info](http://en.wikipedia.org/wiki/Betting_in_poker#Fixed_limit)

### Command Schema

```json
{
  "title": "Schema for LimitOptionsFixed",
  "type": "BluffinMuffin.Protocol.DataTypes.LimitOptionsFixed",
  "properties": {
    "OptionType": {
      "description": "The type of limit you want to apply on raises",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum",
      "enum": [
        "NoLimit",
        "FixedLimit",
        "PotLimit"
      ]
    }
  }
}
```

### Example

```json
{
  "OptionType": "FixedLimit"
}
```

## LimitOptionsNoLimit

A game played with a no-limit betting structure allows each player to raise the bet by any amount up to and including his entire remaining stake at any time. There is generally a minimum opening bet, and raises usually must be at least the amount of the previous raise.

[More Info](http://en.wikipedia.org/wiki/Betting_in_poker#No_limit)

### Command Schema

```json
{
  "title": "Schema for LimitOptionsNoLimit",
  "type": "BluffinMuffin.Protocol.DataTypes.LimitOptionsNoLimit",
  "properties": {
    "OptionType": {
      "description": "The type of limit you want to apply on raises",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum",
      "enum": [
        "NoLimit",
        "FixedLimit",
        "PotLimit"
      ]
    }
  }
}
```

### Example

```json
{
  "OptionType": "NoLimit"
}
```

## LimitOptionsPot

In a pot-limit game no player can raise more than the size of the total pot, which includes Chips collected from previous betting rounds (Starting pot), Previous action in the current betting round (Trail) and A call from the player making the raise

[More Info](http://en.wikipedia.org/wiki/Betting_in_poker#Pot_limit)

### Command Schema

```json
{
  "title": "Schema for LimitOptionsPot",
  "type": "BluffinMuffin.Protocol.DataTypes.LimitOptionsPot",
  "properties": {
    "OptionType": {
      "description": "The type of limit you want to apply on raises",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum",
      "enum": [
        "NoLimit",
        "FixedLimit",
        "PotLimit"
      ]
    }
  }
}
```

### Example

```json
{
  "OptionType": "PotLimit"
}
```

