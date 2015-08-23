
__author__ = 'ericm'
_project_ = 'BluffinMuffin.Protocol'

class CommandDecoder:
    def my_import(name):
        print(name)
        mod = __import__(name)
        components = name.split('.')
        for comp in components[1:]:
            mod = getattr(mod, comp)
        return mod

    def decode_class(obj, name, longName):
        try:
            klass = getattr(__import__(longName, globals(), locals(), longName),name)
            return klass(obj)
        except ImportError:
            return None

    def decode(obj):
        prefixes = [
            '',
            'Lobby',
            'Lobby.QuickMode'
        ]
        for p in prefixes:
            res = CommandDecoder.decode_class(obj,obj['CommandName'],'{0}.{1}'.format(p,obj['CommandName']))
            if res is not None:
                return res
        return None