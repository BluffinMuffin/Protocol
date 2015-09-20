using BluffinMuffin.Protocol.DataTypes.Attributes;

namespace BluffinMuffin.Protocol.DataTypes
{
    /// <summary>
    /// 
    /// </summary>
    public class DiscardInfo
    {
        /// <summary>
        /// The id of the current seat
        /// </summary>
        [ExampleValue(7)]
        public int NoSeat { get; set; }
        /// <summary>
        /// How many cards discarded by the player
        /// </summary>
        [ExampleValue(3)]
        public int NbCardsDiscarded { get; set; }
    }
}
