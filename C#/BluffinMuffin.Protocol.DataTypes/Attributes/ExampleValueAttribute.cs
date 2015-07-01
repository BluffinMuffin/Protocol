using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
