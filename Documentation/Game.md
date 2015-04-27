# Game

These are all the commands that are used during the game. The *Client Commands* are initiated by the client, and the *Server Informations* are initiated by the server.

## Client Commands

 * **[PlayerPlayMoneyCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.PlayerPlayMoneyCommand.md)** 

   The client is telling the server that he plays some money.
   
 * **[PlayerSitInCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.PlayerSitInCommand.md)**

   The client is telling the server that he wants to sit at a specific seat

 * **[PlayerSitOutCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.PlayerSitOutCommand.md)**

   The client is telling the server that he wants to sit out

## Server Informations

 * **[BetTurnEndedCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.BetTurnEndedCommand.md)** 

   This command is issued by the server when a betting round is ending. For example, everybody called on the flop. It's the end of the flop. Every client receive this command.
   
 * **[BetTurnStartedCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.BetTurnStartedCommand.md)**

   This command is issued by the server when a betting round is ending. For example, when the 3 first cards are shown, it's the beginning of the flop.

 * **[GameEndedCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.GameEndedCommand.md)**

   This command is sent at the end of every game. It's important to understand that a *game* is only one iteration. It's starts with blinds, then preflop, then ends when the pot is won. The next iteration will be a new *game*.

 * **[GameStartedCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.GameStartedCommand.md)** 

   This command is sent at the start of every game. It's important to understand that a *game* is only one iteration. It's starts with blinds, then preflop, then ends when the pot is won. The next iteration will be a new *game*.
   
 * **[PlayerHoleCardsChangedCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.PlayerHoleCardsChangedCommand.md)**

   This command is send by the server to inform everybody that the cards of a player just changed. This is used to inform a player of the cards he just got dealed, to inform other players that some cards has been dealt to a player, or to show cards to everybody at showdown.

 * **[PlayerJoinedCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.PlayerJoinedCommand.md)**

   This command is there to inform players that someone just joined the table. This will be sent before the player sits in. If the player is only there to view, people are still notified of his presence.

 * **[PlayerMoneyChangedCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.PlayerMoneyChangedCommand.md)** 

   The server is sharing new information about the money in the pockets of a player.
   
 * **[PlayerTurnBeganCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.PlayerTurnBeganCommand.md)**

   The server sends this command to indicated that it's time for a specific player to play.

 * **[PlayerTurnEndedCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.PlayerTurnEndedCommand.md)**

   Server informs all the clients that a player has taken action.

 * **[PlayerWonPotCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.PlayerWonPotCommand.md)** 

   This command is sent after the showdown to inform clients that some money has been won by some player
   
 * **[SeatUpdatedCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.SeatUpdatedCommand.md)**

   Server informs clients that a seat has changed state. Usually sent when player sits-in or sits-out.

 * **[TableClosedCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.TableClosedCommand.md)**

   Informs the clients that the table is closed and that there will be no more games on this table.

 * **[TableInfoCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.TableInfoCommand.md)**

   Sends all the information about the current state of the table, to put everybody on the same page.
