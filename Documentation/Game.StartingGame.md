# Game - Starting the game
<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/Protocol.Game.StartingGame.png"></p>

At this stage, we are starting the game. If there is blinds or antes, we wait for everybody to put what they need on the table. When everybody has done so or if there wasn't any blinds to put, we are ready for the next stage.

## RECV Commands

* **[PlayerPlayMoneyCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.PlayerPlayMoneyCommand.md)** 

   The client is telling the server that he plays some money.

## SEND Commands

 * **[GameStartedCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.GameStartedCommand.md)** 

   This command is sent at the start of every game. It's important to understand that a *game* is only one iteration. It's starts with blinds, then preflop, then ends when the pot is won. The next iteration will be a new *game*.
   
 * **[PlayerTurnEndedCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.PlayerTurnEndedCommand.md)**

   Server informs all the clients that a player has taken action.