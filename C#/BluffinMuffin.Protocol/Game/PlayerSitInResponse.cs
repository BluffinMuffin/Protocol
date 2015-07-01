using BluffinMuffin.Protocol.DataTypes.Attributes;

namespace BluffinMuffin.Protocol.Game
{
    /// <summary>
    /// The response from the server on the SitInRequest
    /// </summary>
    public class PlayerSitInResponse : AbstractBluffinReponse<PlayerSitInCommand>, IGameCommand
    {
        /// <summary>
        /// The Seat number where the player will sit. It could be different from the one asked if the seat was not available. Wil have -1 if the player is not sitting anywhere.
        /// </summary>
        [ExampleValue(7)]
        public int NoSeat { get; set; }

        /// <summary>
        /// The id of the table where this command needs to go
        /// </summary>
        public int TableId
        {
            get { return Command.TableId; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public PlayerSitInResponse(PlayerSitInCommand command)
            : base(command)
        {
        }
    }
}
