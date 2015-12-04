# 4.*

## 4.0.*

### [4.0.0](https://github.com/Ericmas001/BluffinMuffin.Protocol/releases/tag/v4.0.0) *(2015-12-04)*
 * Documentation for Game Commands (#17)
 * Removing unsused stuff that was only for the server side
 * Enhancement Issue #36: Adding ClientIdentification & ServerIdentification
 * The DLLs are now portable
  * .NET Framework 4
  * Silverlight 5
  * Windows 8
  * Windows Phone 8.1
  * Windows Phone Silverlight 8
  * Xamarin.Android
  * Xamarin.iOS
  * Xamarin.iOS (Classic)

# 3.*

## 3.0.*

### [3.0.0](https://github.com/Ericmas001/BluffinMuffin.Protocol/releases/tag/v3.0.0) *(2015-09-20)*
 * GameTypeEnum now contrains Community, Stud & Draw
 * RoundTypeEnum is no more supported
 * TableInfoCommand is now useless since JoinTableResponse, GameStarted and BetTurnStartedCommand command now have more information. TableInfoCommand have been removed. 
 * Cards in the hand of the player are now represented by FaceUpCards and FaceDownCards. PlayerInfo datatype and PlayerHoleCardsChangedCommand have been modified accordingly.
 * CheckCompatibilityResponse now have an AvailableGames field instead of SupportedRules. GameInfo replaces RuleInfo.
 * Available poker variants that can be implemented by the server are now listed in GameSubTypeEnum
 * CreateTableCommand has been simplified
 * Enhancement Issue #18: Validate email on registering
 * Better support of Stud Poker
 * PlayerTurnBeganCommand now have more information
 * PlayerJoinedCommand and PlayerLeftCommand are replaced with GameMessageCommand.

## 2.3.*

### [2.3.1](https://github.com/Ericmas001/BluffinMuffin.Protocol/releases/tag/v2.3.1) *(2015-09-07)*
 * Python correction to handle empty seats
 * Python correction to handle amount_needed not sended by the server on player_turn_began

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
