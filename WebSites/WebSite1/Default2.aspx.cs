﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmitForm_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            btnSubmitForm.Text = "My form is valid!";
        }
    }

    protected void cusCustom_OnServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = args.Value.Length == 8;
    }
}