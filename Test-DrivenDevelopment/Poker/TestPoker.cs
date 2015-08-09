/*Finish the "Poker" project given in the demo using TDD.
Task 1. In the Card class implement the ToString() method

    Use Test-Driven Development (TDD)
    Test all cases
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker
{
    [TestClass]
    public class Poker
    {
        [TestMethod]
        public void TestCardToStringMethod()
        {
            Card aceOfSpades = new Card(CardFace.Ace, CardSuit.Spades);
            Assert.AreEqual(aceOfSpades.ToString(), "Ace ♠");
        }

        [TestMethod]
        public void TestHandToStringMethod()
        {
            var rndNumber = new Random();
            var listOfCards = new List<ICard>();

            for (int i = 0; i < 5; i++)
            {
                CardFace rndCardFace = (CardFace)rndNumber.Next(2, 15);
                CardSuit rndCardSuit = (CardSuit)rndNumber.Next(1, 5);

                listOfCards.Add(new Card(rndCardFace, rndCardSuit));
            }
            Hand randomHand = new Hand(listOfCards);
            Assert.IsTrue(listOfCards.TrueForAll(x => randomHand.ToString().IndexOf(x.ToString()) > 0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestHandSizeWithTooBigParameter()
        {
            var rndNumber = new Random();
            var listOfCards = new List<ICard>();

            for (int i = 0; i < 20; i++)
            {
                CardFace rndCardFace = (CardFace)rndNumber.Next(2, 15);
                CardSuit rndCardSuit = (CardSuit)rndNumber.Next(1, 5);

                listOfCards.Add(new Card(rndCardFace, rndCardSuit));
            }
            Hand randomHand = new Hand(listOfCards);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestHandSizeWithTooFewCards()
        {
            var listCards = new List<ICard>();
            listCards.Add(new Card(CardFace.Ace, CardSuit.Spades));
            var newHand = new Hand(listCards);
        }

        
        static void Main(string[] args)
        {
            
        }
    }
}
