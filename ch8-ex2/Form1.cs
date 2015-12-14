using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch8_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

            Console.WriteLine("Those same cards, sorted:");
            CardComparer_ByValue cc = new CardComparer_ByValue();
            cards.Sort(cc);

            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}
