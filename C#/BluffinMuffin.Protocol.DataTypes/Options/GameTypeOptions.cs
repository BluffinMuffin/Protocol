using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes.Options
{
    /// <summary>
    /// The type of game the table uses (Community, Draw, Stud)
    /// </summary>
    public abstract class GameTypeOptions : IOption<GameTypeEnum>
    {
        /// <summary>
        /// The type of game you want to play
        /// </summary>
        public abstract GameTypeEnum OptionType { get; }
    }
}
