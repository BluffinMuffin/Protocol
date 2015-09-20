# GameMessageOption

The type of message sent by the server

### Command Schema

```json
{
  "title": "Schema for GameMessageOption",
  "type": "BluffinMuffin.Protocol.DataTypes.Options.GameMessageOption",
  "properties": {
    "OptionType": {
      "description": "The type of message sent by the server",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameMessageEnum",
      "enum": [
        "GeneralInformation",
        "RaisingCapped",
        "StudBringIn",
        "StudHighestHand",
        "PlayerJoined",
        "PlayerLeft"
      ]
    }
  }
}
```

## GameMessageOptionPlayerLeft

BluffinMuffin.Protocol.DataTypes.Options.GameMessageOptionPlayerLeft

### Command Schema

```json
{
  "title": "Schema for GameMessageOptionPlayerLeft",
  "type": "BluffinMuffin.Protocol.DataTypes.Options.GameMessageOptionPlayerLeft",
  "properties": {
    "OptionType": {
      "description": "The type of message sent by the server",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameMessageEnum",
      "enum": [
        "GeneralInformation",
        "RaisingCapped",
        "StudBringIn",
        "StudHighestHand",
        "PlayerJoined",
        "PlayerLeft"
      ]
    },
    "PlayerName": {
      "description": "The name of the player that just left the table.",
      "type": "string"
    }
  }
}
```

### Example

```json
{
  "OptionType": "PlayerLeft",
  "PlayerName": "SpongeBob"
}
```

## GameMessageOptionPlayerJoined

BluffinMuffin.Protocol.DataTypes.Options.GameMessageOptionPlayerJoined

### Command Schema

```json
{
  "title": "Schema for GameMessageOptionPlayerJoined",
  "type": "BluffinMuffin.Protocol.DataTypes.Options.GameMessageOptionPlayerJoined",
  "properties": {
    "OptionType": {
      "description": "The type of message sent by the server",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameMessageEnum",
      "enum": [
        "GeneralInformation",
        "RaisingCapped",
        "StudBringIn",
        "StudHighestHand",
        "PlayerJoined",
        "PlayerLeft"
      ]
    },
    "PlayerName": {
      "description": "The name of the player that just joined the table.",
      "type": "string"
    }
  }
}
```

### Example

```json
{
  "OptionType": "PlayerJoined",
  "PlayerName": "SpongeBob"
}
```

## GameMessageOptionsStudHighestHand

BluffinMuffin.Protocol.DataTypes.Options.GameMessageOptionsStudHighestHand

### Command Schema

```json
{
  "title": "Schema for GameMessageOptionsStudHighestHand",
  "type": "BluffinMuffin.Protocol.DataTypes.Options.GameMessageOptionsStudHighestHand",
  "properties": {
    "Cards": {
      "description": "The cards that are responsible for the Highest Hand",
      "type": "array",
      "items": {
        "type": "string"
      }
    },
    "HighestHand": {
      "description": "The hand that is responsible for the Highest hand",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.PokerHandEnum",
      "enum": [
        "None",
        "HighCard",
        "OnePair",
        "TwoPairs",
        "ThreeOfAKind",
        "Straight",
        "Flush",
        "FullHouse",
        "FourOfAKind",
        "StraightFlush"
      ]
    },
    "OptionType": {
      "description": "The type of message sent by the server",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameMessageEnum",
      "enum": [
        "GeneralInformation",
        "RaisingCapped",
        "StudBringIn",
        "StudHighestHand",
        "PlayerJoined",
        "PlayerLeft"
      ]
    },
    "PlayerName": {
      "description": "The name of the player that has the Highest hand.",
      "type": "string"
    }
  }
}
```

### Example

```json
{
  "OptionType": "StudHighestHand",
  "Cards": [
    "As",
    "Ah"
  ],
  "HighestHand": "OnePair",
  "PlayerName": "SpongeBob"
}
```

## GameMessageOptionsStudBringIn

BluffinMuffin.Protocol.DataTypes.Options.GameMessageOptionsStudBringIn

### Command Schema

```json
{
  "title": "Schema for GameMessageOptionsStudBringIn",
  "type": "BluffinMuffin.Protocol.DataTypes.Options.GameMessageOptionsStudBringIn",
  "properties": {
    "Cards": {
      "description": "The cards that are responsible for the Lowest Hand",
      "type": "array",
      "items": {
        "type": "string"
      }
    },
    "LowestHand": {
      "description": "The hand that is responsible for the lowest hand",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.PokerHandEnum",
      "enum": [
        "None",
        "HighCard",
        "OnePair",
        "TwoPairs",
        "ThreeOfAKind",
        "Straight",
        "Flush",
        "FullHouse",
        "FourOfAKind",
        "StraightFlush"
      ]
    },
    "OptionType": {
      "description": "The type of message sent by the server",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameMessageEnum",
      "enum": [
        "GeneralInformation",
        "RaisingCapped",
        "StudBringIn",
        "StudHighestHand",
        "PlayerJoined",
        "PlayerLeft"
      ]
    },
    "PlayerName": {
      "description": "The name of the player that has the lowest hand.",
      "type": "string"
    }
  }
}
```

### Example

```json
{
  "OptionType": "StudBringIn",
  "Cards": [
    "5s"
  ],
  "LowestHand": "HighCard",
  "PlayerName": "SpongeBob"
}
```

## GameMessageOptionsRaisingCapped

BluffinMuffin.Protocol.DataTypes.Options.GameMessageOptionsRaisingCapped

### Command Schema

```json
{
  "title": "Schema for GameMessageOptionsRaisingCapped",
  "type": "BluffinMuffin.Protocol.DataTypes.Options.GameMessageOptionsRaisingCapped",
  "properties": {
    "OptionType": {
      "description": "The type of message sent by the server",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameMessageEnum",
      "enum": [
        "GeneralInformation",
        "RaisingCapped",
        "StudBringIn",
        "StudHighestHand",
        "PlayerJoined",
        "PlayerLeft"
      ]
    }
  }
}
```

### Example

```json
{
  "OptionType": "RaisingCapped"
}
```

## GameMessageOptionGeneralInformation

BluffinMuffin.Protocol.DataTypes.Options.GameMessageOptionGeneralInformation

### Command Schema

```json
{
  "title": "Schema for GameMessageOptionGeneralInformation",
  "type": "BluffinMuffin.Protocol.DataTypes.Options.GameMessageOptionGeneralInformation",
  "properties": {
    "Message": {
      "description": "Message",
      "type": "string"
    },
    "OptionType": {
      "description": "The type of message sent by the server",
      "type": "BluffinMuffin.Protocol.DataTypes.Enums.GameMessageEnum",
      "enum": [
        "GeneralInformation",
        "RaisingCapped",
        "StudBringIn",
        "StudHighestHand",
        "PlayerJoined",
        "PlayerLeft"
      ]
    }
  }
}
```

### Example

```json
{
  "OptionType": "GeneralInformation",
  "Message": "General message sent by the server"
}
```

