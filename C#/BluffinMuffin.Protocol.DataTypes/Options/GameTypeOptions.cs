using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes.Options
{
    /// <summary>
    /// The type of limit the table uses (NoLimit, PotLimit, FixedLimit)
    /// </summary>
    public abstract class GameTypeOptions : IOption<GameTypeEnum>
    {
        /// <summary>
        /// The type of limit you want to apply on raises
        /// </summary>
        public abstract GameTypeEnum OptionType { get; }
    }
}
