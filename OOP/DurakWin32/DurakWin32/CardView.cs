using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DurakWin32
{
    public partial class CardView : UserControl
    {
        private readonly Durak.objects.Card _card;
        private bool _opened;

        public CardView(Durak.objects.Card c)
        {
            InitializeComponent();
            splitCard.SplitterDistance = 17;
            _card = c;
            _opened = false;
            this.BackColor = Color.Maroon;

            if (Convert.ToInt32(_card.Suit) == 0 || Convert.ToInt32(_card.Suit) == 3)
            {
                numberView.ForeColor = Color.Red;
            }
            if (_card.Number < 11)
            {
                numberView.Text = _card.Number.ToString();
            }
            else
            {
                string s = "";
                switch (_card.Number)
                {
                    case 11: s = "J"; break;
                    case 12: s = "Q"; break;
                    case 13: s = "K"; break;
                    case 14: s = "A"; break;
                }
                numberView.Text = s;
            }
            switch (Convert.ToInt32(_card.Suit))
            {
                case 0: pictureBox.BackgroundImage = PngSuits.spades_red; break;
                case 1: pictureBox.BackgroundImage = PngSuits.clubs_black; break;
                case 2: pictureBox.BackgroundImage = PngSuits.hearts_black; break;
                case 3: pictureBox.BackgroundImage = PngSuits.diamonds_red; break;
            }
            OpenCard();
            this.Click += new EventHandler(CardView_Click);
        }

        void CardView_Click(object sender, EventArgs e)
        {
            if (Opened)
            {
                CloseCard();
            }
            else
            {
                OpenCard();
            }
            
        }

        public bool Opened
        {
            get { return _opened; }
            set { _opened = value; }
        }

        public void OpenCard()
        {
            Opened = true; 
            this.BackColor = Color.White;
            BackgroundImage = null;
            numberView.Visible = Opened;
            pictureBox.Visible = Opened;
        }

        public void CloseCard()
        {
            Opened = false;
            BackgroundImage = PngSuits.back;
            numberView.Visible = Opened;
            pictureBox.Visible = Opened;
        }
    }
}
