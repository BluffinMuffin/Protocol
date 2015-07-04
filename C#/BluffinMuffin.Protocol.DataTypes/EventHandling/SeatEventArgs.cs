using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffinMuffin.Protocol.DataTypes.EventHandling
{
    public class SeatEventArgs : EventArgs
    {
        private readonly SeatInfo m_Seat;
        public SeatInfo Seat { get { return m_Seat; } }

        public SeatEventArgs(SeatInfo s)
        {
            m_Seat = s;
        }
    }
}
