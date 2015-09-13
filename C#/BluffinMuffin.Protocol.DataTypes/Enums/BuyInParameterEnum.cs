using System.ComponentModel;

namespace BluffinMuffin.Protocol.DataTypes.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuyInParameterEnum
    {
        /// <summary>
        /// Fixed Amount
        /// </summary>
        [Description("Fixed Amount")]
        FixedAmount,

        /// <summary>
        /// Multiplicator
        /// </summary>
        [Description("Multiplicator")]
        Multiplicator,

        /// <summary>
        /// Unlimited
        /// </summary>
        [Description("Unlimited")]
        Unlimited
    }
}
