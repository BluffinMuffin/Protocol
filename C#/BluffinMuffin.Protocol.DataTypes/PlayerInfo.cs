using System;
using System.Collections.Generic;
using System.Linq;
using Com.Ericmas001.Games;
using BluffinMuffin.Protocol.DataTypes.Enums;
using Com.Ericmas001.Net.Protocol;
using Newtonsoft.Json;

namespace BluffinMuffin.Protocol.DataTypes
{
    /// <summary>
    /// 
    /// </summary>
    public class PlayerInfo
    {
        private List<GameCard> m_HoleCards;

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
        /// The cards in the hands of the player
        /// </summary>
        [ExampleValues(2,GameCardKind.Spade,GameCardValue.Two,GameCardKind.Heart,GameCardValue.Ace)]
        public GameCard[] HoleCards
        {
            get
            {
                if (m_HoleCards == null || m_HoleCards.Count != 2)
                    return new[] { GameCard.NoCard, GameCard.NoCard };
                return m_HoleCards.ToArray();
            }
            set
            {
                m_HoleCards = value.ToList();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [ExampleValue("TODO")]
        public PlayerStateEnum State { get; set; }

        /// <summary>
        /// true if the player cards are public (ex: during showdown)
        /// </summary>
        [ExampleValue("TODO")]
        public bool IsShowingCards { get; set; }

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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="money"></param>
        public PlayerInfo(String name, int money)
            : this()
        {

            Name = name;
            MoneySafeAmnt = money;
        }

        /// <summary>
        /// Current Money Amount of the player (Safe + Bet)
        /// </summary>
        [JsonIgnore]
        public int MoneyAmnt
        {
            get { return MoneyBetAmnt + MoneySafeAmnt; }
        }

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
                HoleCards = HoleCards.Select(hc => new GameCard(hc.Id)).ToArray(),
                IsShowingCards = IsShowingCards,
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
        /// Player Cards as viewed by himself
        /// </summary>
        [JsonIgnore]
        public GameCard[] Cards
        {
            get { return HoleCards.Select(c => (c == null || !(State >= PlayerStateEnum.AllIn)) ? GameCard.NoCard : c).ToArray(); }
            set
            {
                if (value != null && value.Length == 2)
                    HoleCards = value;
            }
        }

        /// <summary>
        /// Player Cards as viewed by the other players
        /// </summary>
        [JsonIgnore]
        public GameCard[] RelativeCards
        {
            get
            {
                if (!IsShowingCards)
                    return new[] { GameCard.Hidden, GameCard.Hidden };
                return Cards;
            }
        }

        /// <summary>
        /// Is the player Playing ? False if Folded, AllIn or NotPlaying
        /// If set to true, IsAllIn must be false
        /// </summary>
        [JsonIgnore]
        public bool IsPlaying
        {
            get { return State == PlayerStateEnum.Playing; }
        }

        /// <summary>
        /// Is the player AllIn ?
        /// If set to true, IsPlaying must be false
        /// </summary>
        [JsonIgnore]
        public bool IsAllIn
        {
            get { return State == PlayerStateEnum.AllIn; }
        }

        /// <summary>
        /// A player who was playing but disconnected is a Zombie. He will remain in place and put blinds / check / fold
        /// </summary>
        [JsonIgnore]
        public bool IsZombie
        {
            get { return State == PlayerStateEnum.Zombie; }
        }

        /// <summary>
        /// A player who can play has money and is seated !
        /// </summary>
        [JsonIgnore]
        public bool CanPlay
        {
            get { return NoSeat >= 0 && MoneySafeAmnt > 0; }
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
