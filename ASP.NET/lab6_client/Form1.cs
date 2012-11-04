using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab6_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.NORTHWNDEntities proxy =
                new ServiceReference1.NORTHWNDEntities
                    (new Uri("http://localhost:53519/lab6/WcfDataService.svc/"));
            this.customersBindingSource.DataSource = proxy.Customers;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.NORTHWNDEntities proxy =
                new ServiceReference1.NORTHWNDEntities(
                    new Uri("http://localhost:53519/lab6/WcfDataService.svc/"));
            string city = textBox1.Text;

            if (city != "")
            {
                this.customersBindingSource.DataSource = 
                    from c in proxy.Customers where c.City == city select c;
            }

        }


    }
}
