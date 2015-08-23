from protocol import AbstractGameCommand

__author__ = 'ericmas001@gmail.com'



class PlayerSitOutCommand(AbstractGameCommand):
    def __init__(self, obj):
        super().__init__(obj)