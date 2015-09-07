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
        /// 
        /// </summary>
        [JsonIgnore]
        public string[] Cards => FaceDownCards.Concat(FaceUpCards).ToArray();

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
        /// Check if the player has enough money to bet some amount
        /// </summary>
        public bool CanBet(int amnt)
        {
            return amnt <= MoneySafeAmnt;
        }

        /// <summary>
        /// Tries to put some money on the table
        /// </summary>
        /// <returns>True if the money has been successfully played</returns>
        public bool TryBet(int amnt)
        {
            if (!CanBet(amnt))
            {
                return false;
            }

            MoneySafeAmnt -= amnt;
            MoneyBetAmnt += amnt;
            return true;
        }

        /// <summary>
        /// Is the player Playing ? False if Folded, AllIn or NotPlaying
        /// If set to true, IsAllIn must be false
        /// </summary>
        [JsonIgnore]
        public bool IsPlaying => State == PlayerStateEnum.Playing;

        /// <summary>
        /// Is the player AllIn ?
        /// If set to true, IsPlaying must be false
        /// </summary>
        [JsonIgnore]
        public bool IsAllIn => State == PlayerStateEnum.AllIn;

        /// <summary>
        /// A player who was playing but disconnected is a Zombie. He will remain in place and put blinds / check / fold
        /// </summary>
        [JsonIgnore]
        public bool IsZombie => State == PlayerStateEnum.Zombie;

        /// <summary>
        /// A player who can play has money and is seated !
        /// </summary>
        [JsonIgnore]
        public bool CanPlay => NoSeat >= 0 && MoneySafeAmnt > 0;

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
