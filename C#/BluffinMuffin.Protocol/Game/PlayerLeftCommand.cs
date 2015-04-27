namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// This command is there to inform players that someone just **left** the table. (Sitting out doesn't mean leaving) 
    /// </summary>
    public class PlayerLeftCommand : AbstractGameCommand
    {
        /// <summary>
        /// The name of the player that just left the table.
        /// </summary>
        public string PlayerName { get; set; }
    }
}
