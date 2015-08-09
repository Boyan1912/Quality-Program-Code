using System;
using NUnit.Framework;

namespace _02_UnitTestTheDeckClassFromTheSantaseGameEngine
{
    [TestFixture]
    public class TestSantase
    {
        [Test]
        public void TestCorrectNumberOfCards()
        {
            Deck newDeck = new Deck();

            Assert.AreEqual(newDeck.listOfCards, 24);
        }

        [Test]
        public void CheckTrumpCard()
        {
            Deck newDeck = new Deck();

            Assert.AreSame(newDeck.listOfCards[0], newDeck.trumpCard);
        }

        [Test]
        [TestCase(CardType.Ace)]
        [TestCase(CardType.Ten)]
        [TestCase(CardType.King)]
        [TestCase(CardType.Nine)]
        public void TestChangingTrumpCard(Card newCard)
        {
            Deck newDeck = new Deck();
            Assert.AreSame(newCard.trumpCard, newCard);
        }

        static void Main(string[] args)
        {
        }
    }
}
