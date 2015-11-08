using System;
using System.Collections.Generic;
using System.Linq;
using BluffinMuffin.Protocol.DataTypes.Attributes;
using BluffinMuffin.Protocol.DataTypes.Enums;
using Newtonsoft.Json;

namespace BluffinMuffin.Protocol.DataTypes
{
    /// <summary>
    /// 
    /// </summary>
    public class PlayerInfo
    {
        /// <summary>
        /// The seat used by the player
        /// </summary>
        [ExampleValue(7)]
        public int NoSeat { get; set; }

        /// <summary>
        /// The name of the player
        /// </summary>
        [ExampleValue("SpongeBob")]
        public string Name { get; set; }

        /// <summary>
        /// Current Money Amount of the player that he isn't playing with
        /// </summary>
        [ExampleValue(1000)]
        public int MoneySafeAmnt { get; set; }

        /// <summary>
        /// Current Money Amount of the player that he played this round
        /// </summary>
        [ExampleValue(42)]
        public int MoneyBetAmnt { get; set; }

        /// <summary>
        /// The cards in hand that are currently facing up (visible to other players).
        /// </summary>
        [ExampleValues(2, "2s", "Ah")]
        public string[] FaceUpCards { get; set; }

        /// <summary>
        /// The cards in hand that are currently facing down (hidden to other players).
        /// </summary>
        [ExampleValues(2, "??", "??")]
        public string[] FaceDownCards { get; set; }

        /// <summary>
        /// Current state of the player
        /// </summary>
        [ExampleValue(PlayerStateEnum.Playing)]
        public PlayerStateEnum State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PlayerInfo()
        {
            Name = "Anonymous Player";
            NoSeat = -1;
            MoneySafeAmnt = 0;
            MoneyBetAmnt = 0;
            State = PlayerStateEnum.Zombie;
            FaceUpCards = new string[0];
            FaceDownCards = new string[0];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="money"></param>
        public PlayerInfo(string name, int money)
            : this()
        {

            Name = name;
            MoneySafeAmnt = money;
        }

        /// <summary>
        /// All the Cards Facing up or down
        /// </summary>
        [JsonIgnore]
        public string[] Cards => FaceDownCards.Concat(FaceUpCards).ToArray();

        /// <summary>
        /// Current Money Amount of the player (Safe + Bet)
        /// </summary>
        [JsonIgnore]
        public int MoneyAmnt => MoneyBetAmnt + MoneySafeAmnt;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public PlayerInfo Clone()
        {
            return new PlayerInfo()
            {
                NoSeat = NoSeat,
                Name = Name,
                MoneyBetAmnt = MoneyBetAmnt,
                MoneySafeAmnt = MoneySafeAmnt,
                FaceUpCards = FaceUpCards == null ? new string[0] : new List<string>(FaceUpCards).ToArray(),
                FaceDownCards = FaceDownCards == null ? new string[0] : new List<string>(FaceDownCards).ToArray(),
                State = State,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
