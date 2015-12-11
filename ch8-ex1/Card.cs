using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch8_ex1
{
    public class Card
    {
        public int Suit { get; set; }
        public int Value { get; set; }
        public string Name { get; }

        public Card(Suits suit, Values value)
        {
            Name = value.ToString() + " of " + suit.ToString();
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
    }

    
}
