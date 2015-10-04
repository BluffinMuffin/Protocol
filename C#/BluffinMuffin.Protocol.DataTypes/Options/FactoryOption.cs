using System;
using System.Linq;
using System.Reflection;

namespace BluffinMuffin.Protocol.DataTypes.Options
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TOption"></typeparam>
    /// <typeparam name="TEnum"></typeparam>
    public static class FactoryOption<TOption, TEnum>
        where TOption : IOption<TEnum>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static TOption GenerateOption(string enumValue)
        {
            if (!typeof(TEnum).IsEnum)
            {
                throw new ArgumentException("TEnum must be an enumerated type");
            }

            foreach (var t in Assembly.GetExecutingAssembly().GetTypes().Where(t => t != typeof(TOption) && typeof(TOption).IsAssignableFrom(t)))
            {
                var instance = (TOption)Activator.CreateInstance(t);
                if (instance.OptionType.ToString() == enumValue)
                    return instance;
            }
            return default(TOption);
        }
    }
}
