using BluffinMuffin.Protocol.DataTypes.Attributes;

namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// The client is telling the server that he plays some money.
    /// </summary>
    public class PlayerPlayMoneyCommand : AbstractGameCommand
    {
        /// <summary>
        /// Amount of money played
        /// </summary>
        [ExampleValue(42)]
        public int AmountPlayed { get; set; }
    }
}
