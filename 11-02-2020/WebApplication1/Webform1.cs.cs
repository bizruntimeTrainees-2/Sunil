using System;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Webform1 : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = "data source= .; database= customers; integrated security=SSPI";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand("select * from sales_customers2", connection);
            connection.Open();
            GridView.DataSource = sqlCommand.ExecuteReader();
            GridView.DataBind();
        }
    }
}