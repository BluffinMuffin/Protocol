# BluffinMuffin.Protocol

BluffinMuffin Protocol is a Bi-directional Communication Protocol for Poker Game. It has been proven on TCP using C#, but it not confined to it.

The project will be released using [Semantic Versioning](http://semver.org) and developped using [Vincent Driessen's Git Model](http://nvie.com/posts/a-successful-git-branching-model/).

####Project includes
 * **Documentation that defines the protocol**

   A project that states it implements a version of the protocol is saying that it supports what's in the documentation of this version.
   
 * **Libraries for Implementation**

   As an option, the protocol has libraries released with each versions of the protocol. Using these libraries is not a requirement to implement the protocol, but it can save you some time ;)
   
   Libraries currently available in:
    * .Net (For implementations in C#, VB.Net, etc.)
    * Python
    
####Known Implementations
 * **[BluffinMuffin.Beta 0.6.0](http://ericmas001.github.io/BluffinMuffin.Beta)** *(Protocol v1.0.0)*
 * **[BluffinMuffin.Server 0.11.0](http://ericmas001.github.io/BluffinMuffin.Server)** *(Protocol v3.0.0)*
 * **[BluffinMuffin.Client 0.11.0](http://ericmas001.github.io/BluffinMuffin.Client)** *(Protocol v3.0.0)*
 * **[BluffinMuffin.AIClient](https://github.com/mgermain/BluffinMuffin.AIClient)** *(Protocol v2.3.1)*

 

###Current Version: [3.1.0](https://github.com/Ericmas001/BluffinMuffin.Protocol/releases/tag/v3.1.0) *(2015-10-04)*
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
 * *[Full changelog ...](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/CHANGELOG.md)*


----
# Documentation
----

## Playing Cards
Playing Cards sended and received with this protocol are always represented with a [normalized string](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/develop/Documentation/PlayingCard.md).

## Obsolete Information
Obsolete information is information required by the protocol for retro-compatibility, but will disappear in the next major version.
When implementing a version of the protocol that has an Obsolete information, this is what you should do
 * Sender should continue to send the obsolete information
 * Receiver should stop using the information as soon as possible.

## General Commands
General commands are for communication everywhere.

 * **[DisconnectCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/develop/Documentation/BluffinMuffin.Protocol.DisconnectCommand.md)** 

   This command is sent to inform the other end of the Tcp Connection that the communication should end

## Lobby Commands
Lobby commands are for communication about identification, table list, table creations, etc. Everything that is around a poker game, but that isn't directly a poker game.
The lobby has two modes: ***Quick mode*** and ***Registered mode***. 

### Quick mode
The Quick mode is a mode where the money is given to the player when he enters the table. For example, If the amount is set to 1500 on Table1, every player will receive 1500$ to play with when they will enter the Table.
For more information on this mode, see the [Quick Mode Documentation](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/develop/Documentation/LobbyQuickMode.md) section.

### Registered mode
The Registered mode is a mode where a player connects with an account. He then have some money, that he uses throughout different games. When entering a game, he will take some of that money to play, and when he leaves what was left of that money will be given back to him.
For more information on this mode, see the [Registered Mode Documentation](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/develop/Documentation/LobbyRegisteredMode.md) section.

## Game Commands
Game commands are for communication inside a specific table. It's for all the actions on a poker game.
For more information on these commands, see the [Game Commands Documentation](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/develop/Documentation/Game.md) section.
