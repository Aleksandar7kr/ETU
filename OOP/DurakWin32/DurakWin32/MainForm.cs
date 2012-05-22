using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Durak;
using Durak.objects;

namespace DurakWin32
{
    public partial class MainForm : Form
    {
        Deck d = new Deck36();
        Table t;

        public MainForm()
        {
            InitializeComponent();
            t = new Table(6, Suits.Diamonds);
            while (t.CountAttackCards < 6)
            {
                t.PutToAttack(d.GiveNextCard());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableView tv = new TableView(t);
            tv.Dock = DockStyle.Top;
            this.Controls.Add(tv);
            flp.Controls.Add(new PlayerView());
            while (!d.isEmpty())
            {
                CardView temp = new CardView(d.GiveNextCard());
                flp.Controls.Add(temp);
            }
            Refresh();

        }

    }
}
