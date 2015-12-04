using System.Collections.Generic;
using System.Linq;
using BluffinMuffin.Protocol.DataTypes.Enums;
using BluffinMuffin.Protocol.Lobby;
using BluffinMuffin.Protocol.Lobby.RegisteredMode;
using BluffinMuffin.Protocol.Lobby.QuickMode;

namespace BluffinMuffin.Protocol.Tests.DataTypes
{
    public static class LobbyCommandMock
    {
        public static CheckCompatibilityCommand CheckCompatibilityCommand()
        {
            return new CheckCompatibilityCommand()
            {
                ImplementedProtocolVersion = "3.0.0",
                ClientIdentification= "BluffinMuffin.Client .Net 1.0.0"
            };
        }

        public static CheckCompatibilityResponse CheckCompatibilityResponse()
        {
            var response = CheckCompatibilityCommand().ResponseSuccess();
            response.ImplementedProtocolVersion = "3.0.0";
            response.ServerIdentification = "BluffinMuffin.Server .Net 1.0.0";
            response.SupportedLobbyTypes = new[] {LobbyTypeEnum.QuickMode, LobbyTypeEnum.RegisteredMode};
            response.AvailableGames = GameInfoMock.GetAllGames().ToArray();
            return response;
        }

        public static ListTableCommand ListTableCommand()
        {
            return new ListTableCommand() { LobbyTypes = new[] { LobbyTypeEnum.RegisteredMode, LobbyTypeEnum.QuickMode } };
        }

        public static ListTableResponse ListTableResponse()
        {
            var response = ListTableCommand().ResponseSuccess();
            response.Tables = TupleTableMock.AllTables().ToList();
            return response;
        }

        public static JoinTableCommand JoinTableCommand()
        {
            return new JoinTableCommand() {TableId = 42};
        }

        public static JoinTableResponse JoinTableResponse()
        {
            var response = JoinTableCommand().ResponseSuccess();
            response.Params = TableParamsMock.ParamsOne();
            response.TotalPotAmount = 126;
            response.PotsAmount = new List<int>() { 5, 10, 15, 20 };
            response.BoardCards = new[] { "2s", "5h", "Jd", "Ac" };
            response.Seats = SeatInfoMock.AllSeats();
            response.GameHasStarted = true;

            return response;
        }

        public static LeaveTableCommand LeaveTableCommand()
        {
            return new LeaveTableCommand() { TableId = 42 };
        }

        public static CreateTableCommand CreateTableCommand()
        {
            return new CreateTableCommand() {Params = TableParamsMock.ParamsOne()};
        }

        public static CreateTableResponse CreateTableResponse()
        {
            var response = CreateTableCommand().ResponseSuccess();
            response.IdTable = 42;
            return response;
        }
        public static IdentifyCommand IdentifyCommand()
        {
            return new IdentifyCommand() { Name = "SpongeBob" };
        }

        public static IdentifyResponse IdentifyResponse()
        {
            return IdentifyCommand().ResponseSuccess();
        }
        public static AuthenticateUserCommand AuthenticateUserCommand()
        {
            return new AuthenticateUserCommand() { Username = "SpongeBob", Password = "SquarePants" };
        }

        public static AuthenticateUserResponse AuthenticateUserResponse()
        {
            return AuthenticateUserCommand().ResponseSuccess();
        }
        public static CheckDisplayExistCommand CheckDisplayExistCommand()
        {
            return new CheckDisplayExistCommand() { DisplayName = "SpongeBob" };
        }
        public static CheckDisplayExistResponse CheckDisplayExistResponse()
        {
            var response = CheckDisplayExistCommand().ResponseSuccess();
            response.Exist = true;
            return response;
        }
        public static CheckUserExistCommand CheckUserExistCommand()
        {
            return new CheckUserExistCommand() { Username = "SpongeBob" };
        }
        public static CheckUserExistResponse CheckUserExistResponse()
        {
            var response = CheckUserExistCommand().ResponseSuccess();
            response.Exist = true;
            return response;
        }
        public static CreateUserCommand CreateUserCommand()
        {
            return new CreateUserCommand() { Username = "SpongeBob", Password = "SquarePants", DisplayName = "Gary", Email = "Bikini@Bottom.com" };
        }
        public static CreateUserResponse CreateUserResponse()
        {
            return CreateUserCommand().ResponseSuccess();
        }
        public static GetUserCommand GetUserCommand()
        {
            return new GetUserCommand();
        }
        public static GetUserResponse GetUserResponse()
        {
            var response = GetUserCommand().ResponseSuccess();
            response.Email = "Bikini@Bottom.com";
            response.DisplayName = "SquarePants";
            response.Money = 42;
            return response;
        }
    }
}
