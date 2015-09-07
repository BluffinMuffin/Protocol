using System;

namespace BluffinMuffin.Protocol.DataTypes.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    public class ExampleValueAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public object Value { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public ExampleValueAttribute(object value)
        {
            Value = value;
        }
    }
}
