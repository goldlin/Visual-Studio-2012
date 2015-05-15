using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

public partial class Default2 : System.Web.UI.Page
{
    protected override void InitializeCulture()
    {
        Page.Culture = "zh-CN";
        Page.UICulture = "zh-CN";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            using (OdbcConnection connection= new OdbcConnection(ConfigurationManager.ConnectionStrings["MySQLConnStr"].ConnectionString))
            {
                connection.Open();
                using (OdbcCommand command = new OdbcCommand("SELECT name FROM test_users", connection))
                using (OdbcDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Response.Write(dr["name"].ToString() + "<br/>");
                    }
                    dr.Close();
                }
                connection.Close();
            }
        }
        catch (Exception exception)
        {
            Response.Write("Error occured: " + exception.Message);
        }
    }
}