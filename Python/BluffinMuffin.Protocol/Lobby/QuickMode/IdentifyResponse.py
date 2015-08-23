from AbstractResponse import AbstractResponse

__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'


class IdentifyResponse(AbstractResponse):
    def __init__(self, obj, command):
        super().__init__('IdentifyResponse', obj, command)
