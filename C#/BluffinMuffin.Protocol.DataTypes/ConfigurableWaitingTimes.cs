using BluffinMuffin.Protocol.DataTypes.Attributes;

namespace BluffinMuffin.Protocol.DataTypes
{
    /// <summary>
    /// The waiting times (At different stage of the game, the server will wait before continuing to making it feel real !)
    /// </summary>
    public class ConfigurableWaitingTimes
    {
        /// <summary>
        /// Amount of miliseconds (ms) to wait after a player do something.
        /// </summary>
        [ExampleValue(500)]
        public int AfterPlayerAction { get; set; }
        
        /// <summary>
        /// Amount of miliseconds (ms) to wait after cards are dealed
        /// </summary>
        [ExampleValue(500)]
        public int AfterBoardDealed { get; set; }
        /// <summary>
        /// Amount of miliseconds (ms) to wait after pot is won
        /// </summary>
        [ExampleValue(2500)]
        public int AfterPotWon { get; set; }
    }
}
