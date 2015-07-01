using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BluffinMuffin.Protocol
{
    public abstract class AbstractJsonCommand : AbstractCommand
    {
        public override string Encode()
        {
            return JsonConvert.SerializeObject(this, new StringEnumConverter());
        }
    }
}
