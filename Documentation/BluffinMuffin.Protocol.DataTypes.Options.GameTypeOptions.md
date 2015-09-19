# GameTypeOptions

The type of game the table uses (Community, Draw, Stud)

### Command Schema

```json
{
  "title": "Schema for GameTypeOptions",
  "type": "BluffinMuffin.Protocol.DataTypes.Options.GameTypeOptions",
  "properties": {
    "OptionType": {
      "description": "The type of game you want to play",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameTypeEnum",
      "enum": [
        "CommunityCardsPoker",
        "StudPoker",
        "DrawPoker"
      ]
    }
  }
}
```

## GameTypeOptionsCommunity

BluffinMuffin.Protocol.DataTypes.Options.GameTypeOptionsCommunity

### Command Schema

```json
{
  "title": "Schema for GameTypeOptionsCommunity",
  "type": "BluffinMuffin.Protocol.DataTypes.Options.GameTypeOptionsCommunity",
  "properties": {
    "OptionType": {
      "description": "The type of game you want to play",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameTypeEnum",
      "enum": [
        "CommunityCardsPoker",
        "StudPoker",
        "DrawPoker"
      ]
    }
  }
}
```

### Example

```json
{
  "OptionType": "CommunityCardsPoker"
}
```

## GameTypeOptionsStud

BluffinMuffin.Protocol.DataTypes.Options.GameTypeOptionsStud

### Command Schema

```json
{
  "title": "Schema for GameTypeOptionsStud",
  "type": "BluffinMuffin.Protocol.DataTypes.Options.GameTypeOptionsStud",
  "properties": {
    "OptionType": {
      "description": "The type of game you want to play",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameTypeEnum",
      "enum": [
        "CommunityCardsPoker",
        "StudPoker",
        "DrawPoker"
      ]
    }
  }
}
```

### Example

```json
{
  "OptionType": "StudPoker"
}
```

## GameTypeOptionsDraw

BluffinMuffin.Protocol.DataTypes.Options.GameTypeOptionsDraw

### Command Schema

```json
{
  "title": "Schema for GameTypeOptionsDraw",
  "type": "BluffinMuffin.Protocol.DataTypes.Options.GameTypeOptionsDraw",
  "properties": {
    "OptionType": {
      "description": "The type of game you want to play",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameTypeEnum",
      "enum": [
        "CommunityCardsPoker",
        "StudPoker",
        "DrawPoker"
      ]
    }
  }
}
```

### Example

```json
{
  "OptionType": "DrawPoker"
}
```

