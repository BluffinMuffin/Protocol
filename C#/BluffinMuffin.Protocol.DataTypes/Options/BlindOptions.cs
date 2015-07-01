using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes.Options
{
    /// <summary>
    /// The type of blinds the table uses (none, blinds, antes) 
    /// </summary>
    public abstract class BlindOptions : IOption<BlindTypeEnum>
    {
        /// <summary>
        /// The Money unit. Should always be equal to the moneyUnit of the table.
        /// </summary>
        [ExampleValue(10)]
        public int MoneyUnit { get; set; }
        /// <summary>
        /// The type of blinds used for the table
        /// </summary>
        public abstract BlindTypeEnum OptionType { get; }
    }
}
