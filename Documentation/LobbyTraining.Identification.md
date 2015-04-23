# Lobby Training : Identification

This page is about the "Identification" part of the Lobby in Training Mode. For more information on this mode, see the [LobbyTraining](https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/LobbyTraining.md) section.

In training mode, you must **identify** yourself. This action puts a unique name to your Tcp Connection for the server. This name will be used as your playername on every table that you will play.

<p align=center><img src="https://github.com/Ericmas001/BluffinMuffin.Protocol/blob/master/Documentation/Sequence%20Diagrams/LobbyTrainingIdentification.png" alt="Sequence Diagram"></p>

## IdentifyCommand

### Command Schema
```json
{
	"title": "Schema for IdentifyCommand",
	"type": "object",
	"properties": {
		"CommandName": {
			"description": "Always contains 'IdentifyCommand' to distinguish the command from others.",
			"type": "string"
		},
		"Name": {
			"description": "The name you want to have on the server !",
			"type": "string"
		}
	},
	"required": ["CommandName", "Name"]
}
```

### Example
```json
{
	"CommandName":"IdentifyCommand",
	"Name":"SpongeBob"
}
```

## IdentifyResponse

### Command Schema
```json
{
	"title": "Schema for IdentifyResponse",
	"type": "object",
	"properties": {
		"CommandName": {
			"description": "Always contains 'IdentifyResponse' to distinguish the command from others.",
			"type": "string"
		},
		"Ok": {
			"description": "The name you want to have on the server !",
			"type": "boolean"
		},
		"Command": {
			"description": "The command that was sended by the client",
			"type": "object",
			"properties": {
				"CommandName": {
					"description": "Always contains 'IdentifyCommand' to distinguish the command from others.",
					"type": "string"
				},
				"Name": {
					"description": "The name you want to have on the server !",
					"type": "string"
				}
			},
			"required": ["CommandName", "Name"]
		}
	},
	"required": ["CommandName", "Ok", "Command"]
}
```

### Example
```json
{
	"CommandName":"IdentifyResponse",
	"Ok":true,
	"Command":{
		"CommandName":"IdentifyCommand",
		"Name":"SpongeBob"
	}
}
```
