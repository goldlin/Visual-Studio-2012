using System;
using System.Configuration;
using System.Data.SqlClient;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MainConnectionString"].ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT CatalogId as id, catalogName as name FROM Catalog", connection))
                using (var dr = command.ExecuteReader())
                {
                    ddlCatalogs.DataSource = dr;
                    ddlCatalogs.DataBind();
                    dr.Close();
                }
                connection.Close();
            }
        }
        catch (Exception exception)
        {
            Response.Write("Error occurs: " + exception.Message);
            throw;
        }
    }
}