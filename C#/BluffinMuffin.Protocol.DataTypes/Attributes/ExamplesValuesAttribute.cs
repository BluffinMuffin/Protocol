using System;

namespace BluffinMuffin.Protocol.DataTypes.Attributes
{
    public class ExampleValuesAttribute : Attribute
    {
        public int NbObjects { get; private set; }
        public object[][] Values { get; private set; }

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
