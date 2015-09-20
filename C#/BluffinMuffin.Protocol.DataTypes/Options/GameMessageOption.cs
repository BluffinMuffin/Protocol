using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes.Options
{
    /// <summary>
    /// The type of message sent by the server
    /// </summary>
    public abstract class GameMessageOption : IOption<GameMessageEnum>
    {
        /// <summary>
        /// The type of message sent by the server
        /// </summary>
        public abstract GameMessageEnum OptionType { get; }

        /// <summary>
        /// Function to build the message
        /// </summary>
        public abstract string BuildMessage();
    }
}
