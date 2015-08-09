using System;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face && hand.Cards[i].Suit == hand.Cards[j].Suit)
                    {
                        throw new ArgumentException("Each card should be unique");
                    }
                }
            }
            return hand.Cards.Count == 5;
        }

        public bool IsStraightFlush(IHand hand)
        {
            return IsStraight(hand) && IsFlush(hand);
        }

        public bool IsFourOfAKind(IHand hand)
        {
            int count = 1;
            bool fourOfAKindFound = false;
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        count++;
                        if (count == 4)
                        {
                            fourOfAKindFound = true;
                            break;
                        }
                    }
                }
                if (fourOfAKindFound) break;
                count = 1;
            }
            return fourOfAKindFound;
        }

        public bool IsFullHouse(IHand hand)
        {
            var sortedHand = hand.Cards.OrderByDescending(x => x.Face).ToArray();
            int count = 1;
            int index = 0;
            while (sortedHand[index].Face == sortedHand[index + 1].Face)
            {
                count++;
                index++;
            }
            if (count == 3)
            {
                return sortedHand[3].Face == sortedHand[4].Face;
            }
            else if (count == 2)
            {
                return sortedHand[2].Face == sortedHand[4].Face;
            }
            else
            {
                return false;
            }
        }

        public bool IsFlush(IHand hand)
        {
            CardSuit firstCardSuit = hand.Cards[0].Suit;
            return hand.Cards.All(x => x.Suit == firstCardSuit);
        }

        public bool IsStraight(IHand hand)
        {
            var sortedHand = hand.Cards.OrderByDescending(x => x.Face).ToArray();
            bool isStraight = false;
            for (int i = 0; i < sortedHand.Length - 1; i++)
            {
                int j = i + 1;
                isStraight = sortedHand[i].Face - sortedHand[j].Face == 1;
                if (!isStraight) break;
            }
            return isStraight;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            int count = 0;
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                foreach (var card in hand.Cards)
                {
                    if (hand.Cards[i].Face == card.Face)
                    {
                        count++;
                    }
                    if (count == 3)
                    {
                        return true;
                    }
                }
                count = 0;
            }
            return false;
        }

        public bool IsTwoPair(IHand hand)
        {
            bool firstPairFound = false;
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face && firstPairFound)
                    {
                        return true;
                    }
                    else if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        firstPairFound = true;
                    }
                }
            }
            return false;
        }

        public bool IsOnePair(IHand hand)
        {
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            return true;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
           // bool[] resultFirstHand = new bool[9];
           //
           // for (int i = 0; i < resultFirstHand.Length; i++)
           // {
           //     resultFirstHand[i] = IsStraightFlush(firstHand);
           // }
            throw new NotImplementedException();
            
        }
    }
}

