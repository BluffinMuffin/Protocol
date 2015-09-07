using System;

namespace BluffinMuffin.Protocol.DataTypes.Attributes
{
    public class ExampleValueAttribute : Attribute
    {
        public object Value { get; private set; }
        public ExampleValueAttribute(object value)
        {
            Value = value;
        }
    }
}
