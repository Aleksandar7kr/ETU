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
            if (_curAttackCards < _table.CountAttackCards)
            {
                UpdateAttackPanel();
            }
            if (_curDefenceCards < _table.CountDefenceCards)
            {
                UpdateDefencePanel();
            }
        }

        private void UpdateAttackPanel()
        {
            this.attackCardPanel.Controls.Add(
                new CardView((_table.AttackCards)[_curAttackCards++])
            );
            Refresh();
        }

        private void UpdateDefencePanel()
        {
            this.defenceCardPanel.Controls.Add(
                new CardView((_table.DefenceCards)[_curDefenceCards++])
            );
            Refresh();
        }
    }
}
