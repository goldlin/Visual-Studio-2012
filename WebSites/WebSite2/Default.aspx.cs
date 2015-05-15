using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHelloGuys.Text = Resources.Resource.lblHelloGuys;
        lblHelloWorld.Text = GetLocalResourceObject("lblHelloWorld.Text").ToString();

    }
}