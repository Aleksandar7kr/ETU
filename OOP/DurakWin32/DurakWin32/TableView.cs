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
    public partial class TableView : UserControl
    {
        private Table _table;
        private int _curAttackCards;
        private int _curDefenceCards;

        public TableView(Table table)
        {
            _table = table;
            _curAttackCards = 0;
            _curDefenceCards = 0;
            InitializeComponent();

            this.Paint += new PaintEventHandler(TableView_Paint);
        }

        void TableView_Paint(object sender, PaintEventArgs e)
        {
            if (_curAttackCards != _table.CountAttackCards)
            {
                UpdateAttackPanel();
                this.Refresh();
            }
            if (_curDefenceCards != _table.CountDefenceCards)
            {
                UpdateDefencePanel();
            }
        }

        private void UpdateAttackPanel()
        {
            this.attackCardPanel.Controls.Clear();
            foreach (Durak.objects.Card c in _table.AttackCards)
            {
                if (c != null)
                {
                    this.attackCardPanel.Controls.Add(new CardView(c));
                }
            }
            _curAttackCards = _table.CountAttackCards;
            Refresh();
        }

        private void UpdateDefencePanel()
        {
            this.defenceCardPanel.Controls.Clear();
            foreach (Durak.objects.Card c in _table.DefenceCards)
            {
                if (c != null)
                {
                    this.defenceCardPanel.Controls.Add(new CardView(c));
                }
            }
            _curDefenceCards = _table.CountDefenceCards;
            Refresh();
        }
    }
}
