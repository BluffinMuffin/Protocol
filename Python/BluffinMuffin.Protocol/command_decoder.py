import re

__author__ = 'ericmas001@gmail.com'


class CommandDecoder:

    @classmethod
    def _decode_class(cls, obj, name, longName):
        try:
            klass = getattr(__import__(longName, globals(), locals(), longName),name)
            return klass(obj)
        except ImportError:
            return None

    @classmethod
    def decode(cls, obj):
        prefixes = [
            '',
            'lobbie',
            'lobbie.quick_mode'
        ]
        for p in prefixes:
            res = cls._decode_class(obj,obj['CommandName'],'{0}.{1}'.format(p,re.sub('([a-z0-9])([A-Z])', r'\1_\2', re.sub('(.)([A-Z][a-z]+)', r'\1_\2', obj['CommandName'])).lower()))
            if res is not None:
                return res
        return None