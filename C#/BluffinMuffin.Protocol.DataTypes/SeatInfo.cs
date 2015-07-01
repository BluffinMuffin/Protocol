using System.Linq;
using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Enums;
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
        /// The attributes of the seat
        /// </summary>
        [ExampleValues(2, SeatAttributeEnum.CurrentPlayer, SeatAttributeEnum.BigBlind)]
        public SeatAttributeEnum[] SeatAttributes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public SeatInfo()
        {
            SeatAttributes = new SeatAttributeEnum[0];
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
