namespace BluffinMuffin.Protocol.Lobby.RegisteredMode
{
    public class CheckDisplayExistResponse : AbstractBluffinReponse<CheckDisplayExistCommand>
    {
        public bool Exist { get; set; }

        public CheckDisplayExistResponse(CheckDisplayExistCommand command)
            : base(command)
        {
        }
    }
}
