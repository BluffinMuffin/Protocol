using System;

namespace BluffinMuffin.Protocol.DataTypes.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    public class ExampleValuesAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public int NbObjects { get; }
        /// <summary>
        /// 
        /// </summary>
        public object[][] Values { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nbObjects"></param>
        /// <param name="values"></param>
        public ExampleValuesAttribute(int nbObjects, params object[] values)
        {
            NbObjects = nbObjects;
            int nbByO = (NbObjects <= 0 || values == null) ? 0 : values.Length / nbObjects;
            Values = new object[NbObjects][];
            for (int i = 0; i < NbObjects; ++i)
                Values[i] = new object[nbByO];
            if (values != null)
                for (int i = 0; i < values.Length; ++i)
                    Values[i / nbByO][i % nbByO] = values[i];
        }
    }
}
