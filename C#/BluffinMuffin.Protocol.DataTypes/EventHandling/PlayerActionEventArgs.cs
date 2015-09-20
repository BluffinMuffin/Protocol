using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes.EventHandling
{
    /// <summary>
    /// 
    /// </summary>
    public class PlayerActionEventArgs : PlayerInfoEventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        public GameActionEnum Action { get; }

        /// <summary>
        /// 
        /// </summary>
        public int AmountPlayed { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="action"></param>
        /// <param name="amnt"></param>
        public PlayerActionEventArgs(PlayerInfo p, GameActionEnum action, int amnt)
            : base(p)
        {
            Action = action;
            AmountPlayed = amnt;
        }
    }
}
