# LobbyOptions

The type of table it is (QuickMode ? RegisteredMode ?)

### Command Schema

```json
{
  "title": "Schema for LobbyOptions",
  "type": "BluffinMuffin.Protocol.DataTypes.Options.LobbyOptions",
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
```

## LobbyOptionsRegisteredMode

The Registered mode is a mode where a player connects with an account. He then have some money, that he uses throughout different games. When entering a game, he will take some of that money to play, and when he leaves what was left of that money will be given back to him.

### Command Schema

```json
{
  "title": "Schema for LobbyOptionsRegisteredMode",
  "type": "BluffinMuffin.Protocol.DataTypes.Options.LobbyOptionsRegisteredMode",
  "properties": {
    "IsMaximumBuyInLimited": {
      "description": "If Limited, the maximum buy-in will be 100*MoneyUnit. If not, a player can sit with all his money if he wants.",
      "type": "bool"
    },
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
```

### Example

```json
{
  "OptionType": "RegisteredMode",
  "IsMaximumBuyInLimited": true
}
```

## LobbyOptionsQuickMode

The Quick mode is a mode where the money is given to the player when he enters the table. For example, If the amount is set to 1500 on Table1, every player will receive 1500$ to play with when they will enter the Table.

### Command Schema

```json
{
  "title": "Schema for LobbyOptionsQuickMode",
  "type": "BluffinMuffin.Protocol.DataTypes.Options.LobbyOptionsQuickMode",
  "properties": {
    "OptionType": {
      "description": "What type of lobby it is",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.LobbyTypeEnum",
      "enum": [
        "QuickMode",
        "RegisteredMode"
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
  "OptionType": "QuickMode",
  "StartingAmount": 1500
}
```

