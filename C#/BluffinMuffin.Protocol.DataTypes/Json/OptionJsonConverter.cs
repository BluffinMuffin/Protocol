using BluffinMuffin.Protocol.DataTypes.Options;
using Newtonsoft.Json.Linq;

namespace BluffinMuffin.Protocol.DataTypes.Json
{
    public class OptionJsonConverter<TOption, TEnum> : AbstractCustomJsonConverter<TOption>
        where TOption : IOption<TEnum>
    {
        public override TOption ObtainCustomObject(JObject jObject)
        {
            return FactoryOption<TOption, TEnum>.GenerateOption(jObject.Value<string>("OptionType"));
        }
    }
}
