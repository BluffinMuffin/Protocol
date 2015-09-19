from collections import OrderedDict
from bluffinmuffin.protocol.enums import GameMessageEnum
from bluffinmuffin.protocol.enums import PokerHandEnum


class GameMessageOption:
    def __init__(self, option_type, message):
        self.option_type = option_type
        self.message = message

    def __str__(self):
        return '{0}:{1}'.format(
            GameMessageEnum.to_string(self.option_type),
            self.message
        )

    def _encode_specific(self, d):
        return None

    def _encode_specific_end(self, d):
        return None

    def encode(self):
        d = OrderedDict()
        d['OptionType'] = GameMessageEnum.to_string(self.option_type)
        d['Message'] = self.message
        self._encode_specific(d)
        self._encode_specific_end(d)
        return d


class GameMessageOptionGeneralInformation(GameMessageOption):
    def __init__(self, message):
        super().__init__(GameMessageEnum.GeneralInformation,message)

    def __str__(self):
        return super().__str__()

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Message']
        )


class GameMessageOptionPlayerJoined(GameMessageOption):
    def __init__(self, message, player_name):
        super().__init__(GameMessageEnum.PlayerJoined,message)
        self.player_name = player_name

    def __str__(self):
        return super().__str__()

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Message'],
            obj['PlayerName']
        )


class GameMessageOptionPlayerLeft(GameMessageOption):
    def __init__(self, message, player_name):
        super().__init__(GameMessageEnum.PlayerLeft,message)
        self.player_name = player_name

    def __str__(self):
        return super().__str__()

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Message'],
            obj['PlayerName']
        )


class GameMessageOptionsRaisingCapped(GameMessageOption):
    def __init__(self, message):
        super().__init__(GameMessageEnum.RaisingCapped,message)

    def __str__(self):
        return super().__str__()

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Message']
        )


class GameMessageOptionsStudBringIn(GameMessageOption):
    def __init__(self, message, player_name, lowest_hand, cards):
        super().__init__(GameMessageEnum.StudBringIn,message)
        self.player_name = player_name
        self.lowest_hand = lowest_hand
        self.cards = cards

    def __str__(self):
        return super().__str__()

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Message'],
            obj['PlayerName'],
            PokerHandEnum.parse(obj['LowestHand']),
            obj['Cards']
        )


class GameMessageOptionsStudHighestHand(GameMessageOption):
    def __init__(self, message, player_name, highest_hand, cards):
        super().__init__(GameMessageEnum.StudHighestHand,message)
        self.player_name = player_name
        self.highest_hand = highest_hand
        self.cards = cards

    def __str__(self):
        return super().__str__()

    @classmethod
    def decode(cls, obj):
        return cls(
            obj['Message'],
            obj['PlayerName'],
            PokerHandEnum.parse(obj['HighestHand']),
            obj['Cards']
        )


class GameMessageOptionsDecoder():
    @classmethod
    def decode(cls, obj):
        type = GameMessageEnum.parse(obj['OptionType'])
        if type == GameMessageEnum.GeneralInformation:
            return GameMessageOptionGeneralInformation.decode(obj)
        if type == GameMessageEnum.PlayerJoined:
            return GameMessageOptionPlayerJoined.decode(obj)
        if type == GameMessageEnum.PlayerLeft:
            return GameMessageOptionPlayerLeft.decode(obj)
        if type == GameMessageEnum.RaisingCapped:
            return GameMessageOptionsRaisingCapped.decode(obj)
        if type == GameMessageEnum.StudBringIn:
            return GameMessageOptionsStudBringIn.decode(obj)
        if type == GameMessageEnum.StudHighestHand:
            return GameMessageOptionsStudHighestHand.decode(obj)
        return None
