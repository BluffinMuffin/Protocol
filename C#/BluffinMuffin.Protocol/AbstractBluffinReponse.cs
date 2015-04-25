using Newtonsoft.Json;

namespace BluffinMuffin.Protocol
{
    public abstract class AbstractBluffinReponse<T> : AbstractBluffinCommand, IResponse
        where T : AbstractBluffinCommand
    {
        /// <summary>
        /// The command who initiated this response
        /// </summary>
        [JsonProperty(Order = 9999)]
        public T Command { get; set; }

        public override BluffinCommandEnum CommandType
        {
            get { return Command.CommandType; }
        }

        protected AbstractBluffinReponse()
        {
        }

        protected AbstractBluffinReponse(T command)
        {
            Command = command;
        }
    }
}
