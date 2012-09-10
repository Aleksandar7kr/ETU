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
        Game game = new Game();

        PlayerView _userView;
        PlayerView _cpuView;

        int i = 0;



        public MainForm()
        {
            InitializeComponent();
            t = new Table(6, Suits.Diamonds);
            while (t.CountAttackCards < 6)
            {
                t.PutToAttack(d.GiveNextCard());
            }

            _userView = new PlayerView(game.User);
            _cpuView = new PlayerView(game.Cpu);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Card> cpuCards = game.Cpu.Hand;
            List<Card> userCards = game.User.Hand;

            flp.Controls.Add(_cpuView);
            flp.Controls.Add(_userView);
            flp.Controls.Add(new TableView(game.GameTable));
            flp.Controls.Add(new CardView(game._lastCard));
            Refresh();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            game.UserAction(userActionType.defence, game.User.Hand[i++]);
            if (i >= game.User.Hand.Count) i = 0;
            _userView.UpdateHand();
            _cpuView.UpdateHand();
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game.UserAction(userActionType.attack, game.User.Hand[i++]);
            if (i >= game.User.Hand.Count) i = 0;
            _userView.UpdateHand();
            _cpuView.UpdateHand();
            Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game.UserAction(userActionType.take, game.User.Hand[i++]);
            if (i >= game.User.Hand.Count) i = 0;
            _userView.UpdateHand();
            _cpuView.UpdateHand();
            Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            game.UserAction(userActionType.end, game.User.Hand[i++]);
            if (i >= game.User.Hand.Count) i = 0;
            _userView.UpdateHand();
            _cpuView.UpdateHand();
            Refresh();
        }



    }
}
