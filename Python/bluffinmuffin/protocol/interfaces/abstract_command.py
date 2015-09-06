from collections import OrderedDict
import json

from ..enums.bluffin_command_enum import BluffinCommandEnum


class AbstractCommand:

    def __init__(self, command_type):
        self.command_name = self.__class__.__name__
        self.command_type = command_type

    def __str__(self):
        return '[{0}] {1}'.format(BluffinCommandEnum.to_char(self.command_type), self.command_name)

    def _encode_specific(self, d):
        return None

    def _encode_specific_end(self, d):
        return None

    def encode(self):
        d = OrderedDict()
        d['CommandName'] = self.command_name
        self._encode_specific(d)
        self._encode_specific_end(d)
        #return json.dumps(d, sort_keys=False, indent=4, separators=(',', ': '))
        return json.dumps(d, sort_keys=False)
