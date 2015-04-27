using System.ComponentModel;

namespace BluffinMuffin.Protocol.DataTypes.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum LimitTypeEnum
    {
        /// <summary>
        /// NoLimit
        /// </summary>
        [Description("No Limit")]
        NoLimit,

        /// <summary>
        /// FixedLimit
        /// </summary>
        [Description("Fixed Limit")]
        FixedLimit,

        /// <summary>
        /// PotLimit
        /// </summary>
        [Description("Pot Limit")]
        PotLimit
    }
}
