using System.Linq;
using BluffinMuffin.Protocol.DataTypes.Enums;
using Com.Ericmas001.Collections;
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
        public bool IsEmpty { get { return Player == null; } }
        /// <summary>
        /// 
        /// </summary>
        public int NoSeat { get; set; }
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public SeatAttributeEnum[] SerializableAttributes
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
                SerializableAttributes = SerializableAttributes,
            };
        }
    }
}
