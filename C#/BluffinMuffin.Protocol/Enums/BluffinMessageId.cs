using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluffinMuffin.Protocol.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum BluffinMessageId
    {
        /// <summary>
        /// None
        /// </summary>
        None,

        /// <summary>
        /// SpecificServerMessage
        /// </summary>
        SpecificServerMessage,

        /// <summary>
        /// WrongTableState
        /// </summary>
        WrongTableState,

        /// <summary>
        /// NameAlreadyUsed
        /// </summary>
        NameAlreadyUsed,

        /// <summary>
        /// UsernameAlreadyUsed
        /// </summary>
        UsernameAlreadyUsed,

        /// <summary>
        /// UsernameNotFound
        /// </summary>
        UsernameNotFound,

        /// <summary>
        /// InvalidPassword
        /// </summary>
        InvalidPassword,

        /// <summary>
        /// SeatChanged
        /// </summary>
        SeatChanged,

        /// <summary>
        /// NoMoreSeats
        /// </summary>
        NoMoreSeats,

        /// <summary>
        /// NotAuthenticated
        /// </summary>
        NotAuthenticated,
    }
}
