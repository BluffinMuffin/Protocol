from enum import Enum


class BuyInParameterEnum(Enum):
    FixedAmount = 0
    Multiplicator = 1
    Unlimited = 2

    @classmethod
    def parse(cls, str):
        return cls[str]

    @classmethod
    def to_string(cls, value):
        return value.name
