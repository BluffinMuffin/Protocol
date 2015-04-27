using Newtonsoft.Json;

namespace BluffinMuffin.Protocol
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractBluffinReponse<T> : AbstractBluffinCommand, IResponse
        where T : AbstractBluffinCommand
    {
        /// <summary>
        /// The command who initiated this response
        /// </summary>
        [JsonProperty(Order = 9999)]
        public T Command { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public override BluffinCommandEnum CommandType
        {
            get { return Command.CommandType; }
        }

        /// <summary>
        /// 
        /// </summary>
        protected AbstractBluffinReponse()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        protected AbstractBluffinReponse(T command)
        {
            Command = command;
        }
    }
}
