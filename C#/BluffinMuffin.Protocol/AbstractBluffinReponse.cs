namespace BluffinMuffin.Protocol
{
    public abstract class AbstractBluffinReponse<T> : AbstractBluffinCommand, IResponse
        where T : AbstractBluffinCommand
    {
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
