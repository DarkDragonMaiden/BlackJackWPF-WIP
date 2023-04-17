using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWPF_WIP
{
    internal class Card
    {
        // Sets the cards Suit, Rank, and Value
        public string Suit { get; set; }
        public string Rank { get; set; }
        public int Value { get; set; }

        public Card(string suit, string rank, int value)
        {
            Suit = suit;
            Rank = rank;
            Value = value;
        }

        public override string ToString()
        {
            return Rank + " of " + Suit;
        }

    }
}
