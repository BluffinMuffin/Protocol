using System.Collections.Generic;
using BluffinMuffin.Protocol.DataTypes;
using BluffinMuffin.Protocol.DataTypes.Attributes;

namespace BluffinMuffin.Protocol.Lobby
{
    /// <summary>
    /// 
    /// </summary>
    public class ListTableResponse : AbstractBluffinReponse<ListTableCommand>
    {
        /// <summary>
        /// All the active tables on the server
        /// </summary>
        [ExampleValues(1)]
        public List<TupleTable> Tables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public ListTableResponse(ListTableCommand command)
            : base(command)
        {
        }
    }
}
