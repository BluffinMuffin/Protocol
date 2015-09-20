using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes.Options
{
    /// <summary>
    ///  
    /// </summary>
    public class GameMessageOptionsRaisingCapped : GameMessageOption
    {
        /// <summary>
        /// 
        /// </summary>
        public override GameMessageEnum OptionType => GameMessageEnum.RaisingCapped;

        /// <summary>
        /// Function to build the message
        /// </summary>
        public override string BuildMessage() => "Raising is now capped. It can't go higher!";
    }
}
