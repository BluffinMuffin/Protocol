using System.Collections.Generic;
using BluffinMuffin.Protocol.DataTypes;
using Com.Ericmas001.Net.Protocol;

namespace BluffinMuffin.Protocol.Lobby
{
    public class ListTableResponse : AbstractBluffinReponse<ListTableCommand>
    {
        [ExampleValues(1)]
        public List<TupleTable> Tables { get; set; }

        public ListTableResponse(ListTableCommand command)
            : base(command)
        {
        }
    }
}
