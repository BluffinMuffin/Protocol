using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Lobby
{
    public class CreateTableResponse : AbstractBluffinReponse<CreateTableCommand>
    {
        /// <summary>
        /// The id of the table that was created
        /// </summary>
        [ExampleValue(42)]
        public int IdTable { get; set; }

        public CreateTableResponse(CreateTableCommand command)
            : base(command)
        {
        }
    }
}
