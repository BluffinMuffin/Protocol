# Lobby QuickMode

The lobby has two modes: ***Quick mode*** and ***Registered mode***. This Section is about ***Quick mode***. The Quick mode is a mode where the money is given to the player when he enters the table. For example, If the amount is set to 1500 on Table1, every player will receive 1500$ to play with when they will enter the Table.

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequence%20Diagrams/BluffinMuffin.Protocol.Lobby.QuickMode.IdentifyCommand.png" alt="Sequence Diagram"></p>

First, in this mode, you must **identify** yourself. This action puts a unique name to your Tcp Connection for the server. This name will be used as your playername on every table that you will play. For more information, see the [LobbyQuickMode.Identification](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/BluffinMuffin.Protocol.Lobby.QuickMode.IdentifyCommand.md) section.
