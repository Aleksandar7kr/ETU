using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListPicker : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void addAll_Click(object sender, EventArgs e)
    {
        targetList.SelectedIndex = -1;
        foreach (ListItem li in sourceList.Items)
        {
            AddItem(li);
        }
    }
    protected void addOne_Click(object sender, EventArgs e)
    {
        if (sourceList.SelectedIndex >= 0)
        {
            AddItem(sourceList.SelectedItem);
        } 
    }

    protected void remove_Click(object sender, EventArgs e)
    {
        if (targetList.SelectedIndex >= 0)
        {
            targetList.Items.RemoveAt(targetList.SelectedIndex);
            targetList.SelectedIndex = -1;
        } 

    }

    protected void AddItem(ListItem li)
    {
        targetList.SelectedIndex = -1;
        if (this.AllowDuplicates == true)
        {
            targetList.Items.Add(li);
        }
        else
        {
            if (targetList.Items.FindByText(li.Text) == null)
            {
                targetList.Items.Add(li);
            }
        }
    }

    public ListItemCollection SelectionItems
    {
        get { return targetList.Items; }
    }

    public bool AllowDuplicates
    {
        get 
        {
            return (bool)ViewState["allowDuplicates"];
        }
        set
        {
            ViewState["allowDuplicates"] = value;
        }

    }

    public void AddSourceItem(String text)
    {
        sourceList.Items.Add(text);
    }

    public void ClearAll()
    {
        sourceList.Items.Clear();
        targetList.Items.Clear();
    }

}