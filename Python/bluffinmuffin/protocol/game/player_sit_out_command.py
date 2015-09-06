from bluffinmuffin.protocol.interfaces import AbstractGameCommand


class PlayerSitOutCommand(AbstractGameCommand):

    def __init__(self, obj):
        super().__init__(obj)
