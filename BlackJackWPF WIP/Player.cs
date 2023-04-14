using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWPF_WIP
{
    internal class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
        public int TotalValue { get; set; }

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
            TotalValue = 0;
        }

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

        public void ClearHand()
        {
            Hand.Clear();
            TotalValue = 0;
        }

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
