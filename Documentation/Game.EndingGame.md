# Game - Ending game
<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Activities/Protocol.Game.EndingGame.png"></p>

At this stage, we are ending the game. There's the showdown, then we decide the winners, we distribute money and we end the game. Then, we are ready for next stage.

## SEND Commands

 * **[GameEndedCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.GameEndedCommand.md)**

   This command is sent at the end of every game. It's important to understand that a *game* is only one iteration. It's starts with blinds, then preflop, then ends when the pot is won. The next iteration will be a new *game*.

 * **[PlayerHoleCardsChangedCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.PlayerHoleCardsChangedCommand.md)**

   This command is send by the server to inform everybody that the cards of a player just changed. This is used to inform a player of the cards he just got dealed, to inform other players that some cards has been dealt to a player, or to show cards to everybody at showdown.

 * **[PlayerWonPotCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Game.PlayerWonPotCommand.md)** 

   This command is sent after the showdown to inform clients that some money has been won by some player