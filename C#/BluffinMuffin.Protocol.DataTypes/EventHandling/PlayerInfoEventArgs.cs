using System;

namespace BluffinMuffin.Protocol.DataTypes.EventHandling
{
    /// <summary>
    /// 
    /// </summary>
    public class PlayerInfoEventArgs : EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        public PlayerInfo Player { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public PlayerInfoEventArgs(PlayerInfo p)
        {
            Player = p;
        }
    }
}
