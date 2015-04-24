namespace BluffinMuffin.Protocol.Lobby.Training
{
    public class IdentifyResponse : AbstractBluffinReponse<IdentifyCommand>
    {
        /// <summary>
        /// Indicates if the identification was successful
        /// </summary>
        public bool Ok { get; set; }

        public IdentifyResponse(IdentifyCommand command)
            : base(command)
        {
        }
    }
}
