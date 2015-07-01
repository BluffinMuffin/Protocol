using System;
using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes
{
    /// <summary>
    /// 
    /// </summary>
    public class TupleTable : IComparable<TupleTable>
    {
        /// <summary>
        /// The id of the table
        /// </summary>
        [ExampleValue(42)]
        public int IdTable { get; set; }
        /// <summary>
        /// The nb of players currently sitting at the table
        /// </summary>
        [ExampleValue(6)]
        public int NbPlayers { get; set; }
        /// <summary>
        /// The action available to you for this table (Nothing, Join, Leave)
        /// </summary>
        [ExampleValue(LobbyActionEnum.Join)]
        public LobbyActionEnum PossibleAction { get; set; }
        /// <summary>
        /// Parameters of the poker table
        /// </summary>
        public TableParams Params { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(TupleTable other)
        {
            return IdTable.CompareTo(other.IdTable);
        }
    }
}
