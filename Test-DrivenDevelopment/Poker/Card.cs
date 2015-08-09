using System;
using System.Text;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string suitSymbol = "";
            switch ((int) this.Suit)
            {
                case 1: suitSymbol = "♣"; break;
                case 2: suitSymbol = "♦"; break;
                case 3: suitSymbol = "♥"; break;
                case 4: suitSymbol = "♠"; break;
            }
            var strBuilder = new StringBuilder();
            strBuilder.Append(this.Face.ToString() + " " + suitSymbol);
            return strBuilder.ToString();
        }
    }
}
