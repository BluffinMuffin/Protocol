using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffinMuffin.Protocol.DataTypes.Options
{
    public interface IOption<T>
    {
        T OptionType { get; }
    }
}
