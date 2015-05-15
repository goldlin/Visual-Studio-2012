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
        HelloWorldLabel.Text = "Hello, world!";
        //MyUserInfoBoxControl.UserName = "Jane Doe";
        //MyUserInfoBoxControl.UserAge = 33;
        //MyUserInfoBoxControl.UserCountry = "Germany";
        UserInfoBoxControl userInfoBoxControl = (UserInfoBoxControl) LoadControl("~/UserInfoBoxControl.ascx");
        userInfoBoxControl.UserName = "John Doe";
        userInfoBoxControl.UserAge = 78;
        userInfoBoxControl.UserCountry = "Spain";
        phUserInfoBox.Controls.Add(userInfoBoxControl);
    }

    protected void GreetButton_Click(object sender, EventArgs e)
    {
        HelloWorldLabel.Text = "Hello, " + TextInput.Text;
    }

    protected void GreetList_SelectedIndexChanged(object sender, EventArgs e)
    {
        HelloWorldLabel.Text = "Hello, " + GreetList.SelectedValue;
    }

    protected void MyEventUserControl_PageTitleUpdated(object sender, EventArgs e)
    {
        this.Title = MyEventUserControl.PageTitle;
    }

    protected void MyEventUserControl_OnUpdateText(object sender, EventArgs e)
    {
        HelloWorldLabel.Text = "Page Title is updated to " + MyEventUserControl.PageTitle + "!";
    }
}