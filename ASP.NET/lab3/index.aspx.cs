using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab3
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label myLabel = new Label();
            myLabel.Text = "Sample label";

            Panel1.Controls.Add(myLabel);
        }
    }
}