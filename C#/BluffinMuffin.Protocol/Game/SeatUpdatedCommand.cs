using BluffinMuffin.Protocol.DataTypes;

namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// Server informs clients that a seat has changed state. Usually sent when player sits-in or sits-out.
    /// </summary>
    public class SeatUpdatedCommand : AbstractGameCommand
    {
        /// <summary>
        /// The seat that has changed state
        /// </summary>
        public SeatInfo Seat { get; set; }
    }
}
