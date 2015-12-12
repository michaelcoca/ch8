using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch8_ex1
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
            int numberBetween0and3 = random.Next(4);
            int numberBetween1and13 = random.Next(1, 14);

            Card.Suits suit = (Card.Suits)numberBetween0and3;
            Card.Values value = (Card.Values)numberBetween1and13;
            Card card = new Card(suit, value);
            label1.Text = card.Name;
        }
    }
}
