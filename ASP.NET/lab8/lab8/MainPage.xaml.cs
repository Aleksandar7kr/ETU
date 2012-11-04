using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace lab8
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            string dateString;
            if (calendar.SelectedDate == null)
            {
                dateString = "<date not selected>";
            }
            else
            {
                dateString = calendar.SelectedDate.ToString();
            }
            message.Text = "Hi " + name.Text + "\n" +
                "Selected Date: " + dateString; 
        }
    }
}
