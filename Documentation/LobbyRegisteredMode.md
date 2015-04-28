# Lobby RegisteredMode

The lobby has two modes: ***Quick mode*** and ***Registered mode***. This Section is about ***Registered mode***. The Registered mode is a mode where a player connects with an account. He then have some money, that he uses throughout different games. When entering a game, he will take some of that money to play, and when he leaves what was left of that money will be given back to him.

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequences/BluffinMuffin.Protocol.Lobby.RegisteredMode.png" alt="Sequence Diagram"></p>

 * **[CheckCompatibilityCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Lobby.CheckCompatibilityCommand.md)** *(Optional)*

   At the beginning, it's a good idea to **Check Compatibility** between client and server !

 * **[CheckUserExistCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Lobby.RegisteredMode.CheckUserExistCommand.md)** *(Optional)* 

   In the User Creation Process, it's useful to check if the username is already taken. You can then validate the username before actually creating the user. (Username is the name used to connect)

 * **[CheckDisplayExistCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Lobby.RegisteredMode.CheckDisplayExistCommand.md)** *(Optional)* 

   In the User Creation Process, it's useful to check if the display name is already taken. You can then validate the display name before actually creating the user. (Display name is the name viewed by other players on the table)

 * **[CreateUserCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Lobby.RegisteredMode.CreateUserCommand.md)** *(Optional)* 

   This commands will create a new user in the database.

 * **[AuthenticateUserCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Lobby.RegisteredMode.AuthenticateUserCommand.md)** 

   This command will try to authenticate the client against the user database on the server.
   
 * **[GetUserCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Lobby.RegisteredMode.GetUserCommand.md)** *(Optional)* 

   This command will Get the information about a player. This information should be only for the player itself.

 * **[CreateTableCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Lobby.CreateTableCommand.md)** *(Optional)*

   If you want to create a new table, you can send a **Create Table** command to the server with all the parameters that you want on your table

 * **[ListTableCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Lobby.ListTableCommand.md)** *(Optional)*

   You can also ask for the **List of Tables** currently open on the server.

 * **[JoinTableCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Lobby.JoinTableCommand.md)** 

   To **Join a Table**, you must specify an ID that you got creating a table or listing tables.

 * **[LeaveTableCommand](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Lobby.LeaveTableCommand.md)** 

   To **Leave a Table**, you must specify an ID of a table that you are in.
