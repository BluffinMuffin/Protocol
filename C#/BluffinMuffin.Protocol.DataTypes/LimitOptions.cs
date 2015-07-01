using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes
{
    /// <summary>
    /// The type of limit the table uses (NoLimit, PotLimit, FixedLimit)
    /// </summary>
    public abstract class LimitOptions : IOption<LimitTypeEnum>
    {
        /// <summary>
        /// The type of limit you want to apply on raises
        /// </summary>
        public abstract LimitTypeEnum OptionType { get; }
    }
}
