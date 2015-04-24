namespace BluffinMuffin.Protocol.Lobby.Training
{
    /// <summary>
    /// This page is about the "Identification" part of the Lobby in Training Mode. For more information on this mode, see the [LobbyTraining]({Link:LobbyTraining}) section.
    /// In training mode, you must **identify** yourself. This action puts a unique name to your Tcp Connection for the server. This name will be used as your playername on every table that you will play.
    /// </summary>
    public class IdentifyCommand : AbstractLobbyCommand, ICommandWithResponse<IdentifyResponse>
    {
        /// <summary>
        /// The name you want to have on the server !
        /// </summary>
        public string Name { get; set; }

        public IdentifyResponse Response(bool success)
        {
            return new IdentifyResponse(this) { Ok = success };
        }
    }
}
