using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["username"] != null)
        {
            labelName.Text = Request.Cookies["username"].Value;
        }

        Trace.TraceFinished += new TraceContextEventHandler(Trace_TraceFinished);
        
        if (Page.IsPostBack)
        {
            Trace.Write("debugging", "Page load (postback)");
        }
        else
        {
            Trace.Write("debugging", "Page load (first time)");
        } 
    }

    void Trace_TraceFinished(object sender, TraceContextEventArgs e)
    {
        foreach (TraceContextRecord traceRecord in e.TraceRecords)
        {
            if (traceRecord.Category == "debugging")
            {
                Response.Write("<br>" + traceRecord.Message);
            }
        }  
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Trace.Warn("debugging", "start button click handler");

        labelName.Text = Server.HtmlEncode(textName.Text);
        Response.Cookies["username"].Value = labelName.Text;
        Response.Cookies["username"].Expires = DateTime.Now.AddMinutes(30);

        Trace.Warn("debugging", "stop button click handler");
    }
}