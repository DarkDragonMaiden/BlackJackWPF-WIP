using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWPF_WIP
{
    internal class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
        public int TotalValue { get; set; }
        // Sets name to "player" and sets hands with new cards making the total value zero
        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
            TotalValue = 0;
        }
        // Adds a card to the players hand and if you have an ace, or more, calculates whether it is over 21 or not and sets it to 1 or 11
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
        // Clears the hand an sets the total value to 0
        public void ClearHand()
        {
            Hand.Clear();
            TotalValue = 0;
        }
        // Shows the player, the cards in the hand, and the total value of the cards combined.
        public void DisplayHand()
        {
            Console.Write(Name + "'s hand: ");
            foreach (Card card in Hand)
            {
                Console.Write(card.ToString() + " ");
            }
            Console.WriteLine("(Total value: " + TotalValue + ")");
        }

    }
}
