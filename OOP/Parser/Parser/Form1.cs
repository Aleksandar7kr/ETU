using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CalculationTree ct = new CalculationTree(new Parser().getTree(fTextBox.Text));
                List<double> point = new List<double>();
                string[] coord = startTextBox.Text.Split(';');
                for (int i = 0; i < coord.Length; i++)
                {
                    point.Add(double.Parse(coord[i]));
                }
                double eps = double.Parse(epsTextBox.Text); 
                Method m = new Method(ct, point, eps);
                m.Rosenbrock();

                List<double> min = m.getRes();
                resTextBox.Text = "f_min(";
                for (int i = 0; i < ct.getVar().Count; i++)
                {
                    resTextBox.Text += ct.getVar()[i] + ";";
                }
                resTextBox.Text = resTextBox.Text.Substring(0, resTextBox.Text.Length - 1);
                resTextBox.Text += ") = (";

                for (int i = 0; i < min.Count; i++)
                {
                    resTextBox.Text += min[i] + ";";
                }
                resTextBox.Text = resTextBox.Text.Substring(0, resTextBox.Text.Length - 1);
                resTextBox.Text += ")";
                resTextBox.Text += Environment.NewLine;
                resTextBox.Text += "number of iteration: " + m.getK();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
