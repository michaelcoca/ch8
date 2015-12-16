﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch8_ex2
{
    public class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public string Name {
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }

        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public enum Suits
        {
            Spades,
            Clubs,
            Diamonds,
            Hearts,
        }

        public enum Values
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13,
        }

        public override string ToString()
        {
            return Name;
        }
    }

    
}
