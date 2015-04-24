# LimitOptions

BluffinMuffin.Protocol.DataTypes.LimitOptions

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
        "FixedLimit",
        "NoLimit",
        "PotLimit"
      ]
    }
  }
}
```

## LimitOptionsFixed

### Command Schema

```json
{
  "title": "Schema for LimitOptionsFixed",
  "type": "BluffinMuffin.Protocol.DataTypes.LimitOptionsFixed",
  "properties": {
    "OptionType": {
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum",
      "enum": [
        "FixedLimit",
        "NoLimit",
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

### Command Schema

```json
{
  "title": "Schema for LimitOptionsNoLimit",
  "type": "BluffinMuffin.Protocol.DataTypes.LimitOptionsNoLimit",
  "properties": {
    "OptionType": {
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum",
      "enum": [
        "FixedLimit",
        "NoLimit",
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

### Command Schema

```json
{
  "title": "Schema for LimitOptionsPot",
  "type": "BluffinMuffin.Protocol.DataTypes.LimitOptionsPot",
  "properties": {
    "OptionType": {
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.LimitTypeEnum",
      "enum": [
        "FixedLimit",
        "NoLimit",
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

