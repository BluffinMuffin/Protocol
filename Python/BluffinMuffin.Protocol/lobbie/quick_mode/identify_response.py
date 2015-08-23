from abstract_response import AbstractResponse
from lobbie.quick_mode.identify_command import IdentifyCommand

__author__ = 'ericmas001@gmail.com'



class IdentifyResponse(AbstractResponse):
    def __init__(self, obj):
        super().__init__(obj, IdentifyCommand(obj['Command']))