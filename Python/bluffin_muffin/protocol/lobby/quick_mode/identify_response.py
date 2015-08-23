from Python.bluffin_muffin.protocol.abstract_response import AbstractResponse
from identify_command import IdentifyCommand

__author__ = 'ericmas001@gmail.com'



class IdentifyResponse(AbstractResponse):
    def __init__(self, obj):
        super().__init__(obj, IdentifyCommand(obj['Command']))