using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.DataTypes
{
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

        public ConfigurableWaitingTimes()
        {
            AfterPlayerAction = 0;
            AfterBoardDealed = 0;
            AfterPotWon = 0;
        }
    }
}
