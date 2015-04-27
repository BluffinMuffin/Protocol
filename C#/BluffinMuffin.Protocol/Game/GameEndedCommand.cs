namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// This command is sent at the end of every game.
    /// It's important to understand that a *game* is only one iteration. It's starts with blinds, then preflop, then ends when the pot is won. The next iteration will be a new *game*.
    /// </summary>
    public class GameEndedCommand : AbstractGameCommand
    {
    }
}
