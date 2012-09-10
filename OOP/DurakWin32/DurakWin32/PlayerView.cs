using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Durak;

namespace DurakWin32
{
    public partial class PlayerView : UserControl
    {
        Player _player;
        int _count;

        public PlayerView(Durak.Player _p)
        {
            InitializeComponent();
            _player = _p;
            foreach(Durak.objects.Card c in _player.Hand)
            {
                handVew.Controls.Add(new CardView(c));
            }
            _count = _p.Hand.Count;
            this.Paint += new PaintEventHandler(PlayerView_Paint);
            
        }

        void PlayerView_Paint(object sender, PaintEventArgs e)
        {
        }

        public void AddCard()
        {
            this.handVew.Controls.Add(new CardView(_player.Hand[_player.CardCount-1]));
        }

        public void UpdateHand()
        {
            this.handVew.Controls.Clear();
            foreach (Durak.objects.Card c in _player.Hand)
            {
                handVew.Controls.Add(new CardView(c));
            }
        }
    }
}
