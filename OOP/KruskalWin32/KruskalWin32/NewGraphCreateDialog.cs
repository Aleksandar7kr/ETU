using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KruskalWin32
{
    public partial class NewGraphCreateDialog : Form
    {
        public NewGraphCreateDialog()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                int n = int.Parse(tbVertexNumber.Text);
                if (n >= 2 && n <= 20)
                {
                    IntData.Value = n;
                    this.Close();
                }
                else throw new FormatException();
            }
            catch(Exception)
            {
                tbVertexNumber.Text = "2";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
