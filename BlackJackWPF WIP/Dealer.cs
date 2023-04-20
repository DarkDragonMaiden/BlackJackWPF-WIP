using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWPF_WIP
{
    internal class Dealer
    {
        // The cards in the hand and the total value of the cards.
        public List<Card> Hand { get; set; }
        public int TotalValue { get; set; }
        // Dealer hands and the total value of it
        public Dealer()
        {
            Hand = new List<Card>();
            TotalValue = 0;
        }
        // Adds a card to the dealer and if they have an ace, or more, calculates whether it is over 21 or not and sets it to 1 or 11
        public void AddCard(Card card)
        {
            Hand.Add(card);
            TotalValue += card.Value;
            if (TotalValue > 21)
            {
                foreach (Card c in Hand)
                {
                    if (c.Rank == "Ace" && c.Value == 11)
                    {
                        c.Value = 1;
                        TotalValue -= 10;
                        break;
                    }
                }
            }
        }
        // Removes Dealer hands and set to 0
        public void ClearHand()
        {
            Hand.Clear();
            TotalValue = 0;
        }
        // The dealers hand and hides the cards and total value of the cards
        public void DisplayHand(bool showFirstCard)
        {
            Console.Write("Dealer's hand: ");
            if (showFirstCard)
            {
                Console.Write(Hand[0] + " ");
                Console.Write("???");
            }
            else
            {
                foreach (Card card in Hand)
                {
                    Console.Write(card + " ");
                }
                Console.WriteLine("(Total value: " + TotalValue + ")");
            }
            Console.WriteLine();
        }
        // Calculates whether the dealer should hit or stand if value is less than 17
        public bool ShouldHit()
        {
            if (TotalValue > 17)
                return true;
            else if (TotalValue == 17)
                return Hand.Any(h =>  h.Rank == "Ace" && h.Value == 11);
            return false;
        }
    }
}
