using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch8_ex2_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Card> cards = new List<Card>();

            Console.WriteLine("Five random cards:");
            for (int i = 0; i < 5; i++)
            {
                Card card = new Card((Card.Suits)random.Next(4), (Card.Values)random.Next(1, 14));
                Console.WriteLine(card.Name);
                cards.Add(card);
            }

            Console.WriteLine();
            Console.WriteLine("Those same cards, sorted:");
            CardComparer_ByValue cc = new CardComparer_ByValue();
            cards.Sort(cc);

            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }

            Console.ReadKey();
        }
    }
}
