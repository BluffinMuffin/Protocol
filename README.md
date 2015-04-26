# BluffinMuffin.Protocol
Communication Protocol for Poker Game# Lobby QuickMode

## General Commands
General commands are for communication everywhere.

 * **[DisconnectCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.DisconnectCommand.md)** 

   This command is sent to inform the other end of the Tcp Connection that the communication should end

## Lobby Commands
Lobby commands are for communication about identification, table list, table creations, etc. Everything that is around a poker game, but that isn't directly a poker game.
The lobby has two modes: ***Quick mode*** and ***Registered mode***. 

### Quick mode
The Quick mode is a mode where the money is given to the player when he enters the table. For example, If the amount is set to 1500 on Table1, every player will receive 1500$ to play with when they will enter the Table.
For more information on this mode, see the [Quick Mode Documentation](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/LobbyQuickMode.md) section.

### Registered mode
The Registered mode is a mode where a player connects with an account. He then have some money, that he uses throughout different games. When entering a game, he will take some of that money to play, and when he leaves what was left of that money will be given back to him.
For more information on this mode, see the [Registered Mode Documentation](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/LobbyRegisteredMode.md) section.

## Game Commands
Game commands are for communication inside a specific table. It's for all the actions on a poker game.
