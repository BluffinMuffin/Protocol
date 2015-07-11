using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BluffinMuffin.Protocol.DataTypes;
using BluffinMuffin.Protocol.DataTypes.Attributes;

namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// This command is issued by the server when a discard round is ending, after all players have sent a PlayerDiscardActionCommand that fits the discard round limitations.
    /// </summary>
    public class DiscardRoundEndedCommand : AbstractGameCommand
    {
        /// <summary>
        /// The minimum number of cards that a player must discard
        /// </summary>
        [ExampleValues(1)]
        public DiscardInfo[] CardsDiscarded { get; set; }
    }
}
