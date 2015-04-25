using System.Linq;
using BluffinMuffin.Protocol.DataTypes.Enums;
using Com.Ericmas001.Collections;
using Com.Ericmas001.Net.Protocol;
using Newtonsoft.Json;

namespace BluffinMuffin.Protocol.DataTypes
{
    /// <summary>
    /// 
    /// </summary>
    public class SeatInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public bool IsEmpty { get { return Player == null; } }
        /// <summary>
        /// The id of the current seat
        /// </summary>
        [ExampleValue(7)]
        public int NoSeat { get; set; }
        /// <summary>
        /// The information of the player sitting in this seat. If null, there is nobody.
        /// </summary>
        public PlayerInfo Player { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public ConcurrentList<SeatAttributeEnum> Attributes
        {
            get;
            set;
        }
        /// <summary>
        /// The attributes of the seat
        /// </summary>
        [ExampleValues(2, SeatAttributeEnum.CurrentPlayer, SeatAttributeEnum.BigBlind)]
        public SeatAttributeEnum[] SeatAttributes
        {
            get
            {
                return Attributes.ToArray();
            }
            set
            {
                value.ToList().ForEach(x => Attributes.Add(x));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public SeatInfo()
        {
            Attributes = new ConcurrentList<SeatAttributeEnum>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SeatInfo Clone()
        {
            if (IsEmpty)
                return new SeatInfo();
            return new SeatInfo()
            {
                Player = Player.Clone(),
                NoSeat = NoSeat,
                SeatAttributes = SeatAttributes,
            };
        }
    }
}
