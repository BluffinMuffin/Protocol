using System;

namespace BluffinMuffin.Protocol.DataTypes.EventHandling
{
    /// <summary>
    /// 
    /// </summary>
    public class SeatEventArgs : EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        public SeatInfo Seat { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        public SeatEventArgs(SeatInfo s)
        {
            Seat = s;
        }
    }
}
