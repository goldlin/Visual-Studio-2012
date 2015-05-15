using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EventUserControl : System.Web.UI.UserControl
{
    private string pageTitle;
    public event EventHandler PageTitleUpdated;
    public event EventHandler UpdateText;
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnUpdatePageTitle_Click(object sender, EventArgs e)
    {
        this.pageTitle = txtPageTitle.Text;
        if (PageTitleUpdated != null)
            PageTitleUpdated(this, EventArgs.Empty);
        if (UpdateText != null)
            UpdateText(this, EventArgs.Empty);
    }

    public string PageTitle
    {
        get { return pageTitle; }
    }
}