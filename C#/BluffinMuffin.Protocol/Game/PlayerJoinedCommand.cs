namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// This command is there to inform players that someone just joined the table. This will be sent before the player sits in. If the player is only there to view, people are still notified of his presence.
    /// </summary>
    public class PlayerJoinedCommand : AbstractGameCommand
    {
        /// <summary>
        /// The name of the player that just joined the table.
        /// </summary>
        public string PlayerName { get; set; }
    }
}
