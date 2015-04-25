namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    public class CheckUserExistResponse : AbstractBluffinReponse<CheckUserExistCommand>
    {
        public bool Exist { get; set; }

        public CheckUserExistResponse(CheckUserExistCommand command)
            : base(command)
        {
        }
    }
}
