# PlayingCard

During communication with this protocol, you will have to send or receive playing cards. Cards are always represented with a string.
String representation is in the '{value}{suit}' format where `{value} = [2,3,4,5,6,7,8,9,10,J,Q,K,A]` and `{suit} = [S,D,H,C]`. Special representation like "" or "??" are also possible, see the *Specials* section.

## Values

 * 2 : 2
 * 3 : 3
 * 4 : 4
 * 5 : 5
 * 6 : 6
 * 7 : 7
 * 8 : 8
 * 9 : 9
 * 10 : 10
 * J : Jack
 * Q : Queen
 * K : King
 * A : Ace
 
## Suits

 * S : Spades (♠)
 * D : Diamonds (♦)
 * H : Hearts (♥)
 * C : Clubs (♣)

## Specials

 * "??" : Means that the card is there but is not revealed
 * "" (String.Empty) : Means *No Card*