# 2.*

## 2.3.*

### [2.3.0](https://github.com/Ericmas001/BluffinMuffin.Protocol/releases/tag/v2.3.0) *(2015-09-06)*
 * Correction in documentations (#22)
 * Adding "AmountNeeded" to the PlayerTurnBeganCommand (#29)
 * Python commands now accept data in __init__. Decoding json is now done with decode(obj)
 * Python tests now compare json with object
 * Python tests are now splitted in multiple tests, not juste one big ugly test

## 2.2.*

### [2.2.0](https://github.com/Ericmas001/BluffinMuffin.Protocol/releases/tag/v2.2.0) *(2015-07-11)*
 * Addin python libraries
 * Adding the DiscardRoundStartedCommand
 * Adding the DiscardRoundEndedCommand
 * Adding the PlayerDiscardActionCommand
 * Minor corrections on documentation

## 2.1.*

### [2.1.0](https://github.com/Ericmas001/BluffinMuffin.Protocol/releases/tag/v2.1.0) *(2015-07-05)*
 * Adding some event handling for easier implementation
 * Adding obsolete information to the documentation
 * RoundTypeEnum enum and usage is now obsolete.

## 2.0.*

### [2.0.1](https://github.com/Ericmas001/BluffinMuffin.Protocol/releases/tag/v2.0.1) *(2015-07-01)*
 * Stop crashing when no cards

### [2.0.0](https://github.com/Ericmas001/BluffinMuffin.Protocol/releases/tag/v2.0.0) *(2015-07-01)*
 * Getting rid of all the Com.Ericmas001 DLLs for easier implementations
 * Adding a normalized way to send cards as string
 * Renaming properties of some commands making them easier to understand at first glance

# 1.*

## 1.1.*

### [1.1.1](https://github.com/Ericmas001/BluffinMuffin.Protocol/releases/tag/v1.1.1) *(2015-07-01)*
 * "None" was missing but needed in "PokerHandEnum"
 * BluffinMuffin.Protocol.Tests.DataTypes was missing from the package

### [1.1.0](https://github.com/Ericmas001/BluffinMuffin.Protocol/releases/tag/v1.1.0) *(2015-07-01)*
 * Improving PlayerWonPotCommand with "TotalPotAmount", "WinningCards" and "WinningHand"

## 1.0.*

### [1.0.1](https://github.com/Ericmas001/BluffinMuffin.Protocol/releases/tag/v1.0.1) *(2015-05-04)*
 * Readme was improved
 * Changelog page added
 * Assembly versions has been normalized
 * Diagrams were missing or incorrect (#16)

### [1.0.0](https://github.com/Ericmas001/BluffinMuffin.Protocol/releases/tag/v1.0) *(2015-04-27)*
 * First version of the protocol.
