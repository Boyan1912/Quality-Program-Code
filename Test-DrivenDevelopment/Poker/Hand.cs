/*Task 2. In the Hand class implement the ToString() method

    Use Test-Driven Development (TDD)
    Test all cases

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            return String.Join(", ", this.Cards);
        }
    }
}