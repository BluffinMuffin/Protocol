# BluffinMuffin.Protocol
Communication Protocol for Poker Game# Lobby Training

## General Commands
General commands are for communication everywhere. For example, the "Disconnect" command.

## Lobby Commands
Lobby commands are for communication about identification, table list, table creations, etc. Everything that is around a poker game, but that isn't directly a poker game.
The lobby has two modes: ***Training Mode*** and ***Career Mode***. 

### Training Mode
The training mode is a mode where the money is given to the player when he enters the table. For example, If the amount is set to 1500 on Table1, every player will receive 1500$ to play with when they will enter the Table.
For more information on this mode, see the [LobbyTraining](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/C%23/Documentation/LobbyTraining.md) section.

### Career Mode
The career mode is a mode where a player connects with an account. He then have some money, that he uses throughout different games. When entering a game, he will take some of that money to play, and when he leaves what was left of that money will be given back to him.

## Game Commands
Game commands are for communication inside a specific table. It's for all the actions on a poker game.
