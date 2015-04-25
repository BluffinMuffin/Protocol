using System;
using BluffinMuffin.Protocol.DataTypes.Enums;

namespace BluffinMuffin.Protocol.DataTypes
{
    /// <summary>
    /// 
    /// </summary>
    public class TupleTable : IComparable<TupleTable>
    {
        /// <summary>
        /// 
        /// </summary>
        public int IdTable { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int BigBlind { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int NbPlayers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public LobbyActionEnum PossibleAction { get; set; }
        /// <summary>
        /// 
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
