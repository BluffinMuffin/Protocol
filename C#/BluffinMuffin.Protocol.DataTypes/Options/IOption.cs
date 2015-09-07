namespace BluffinMuffin.Protocol.DataTypes.Options
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IOption<out T>
    {
        /// <summary>
        /// 
        /// </summary>
        T OptionType { get; }
    }
}
