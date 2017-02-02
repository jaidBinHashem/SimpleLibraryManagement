using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Configuration;
using System.Web.UI.WebControls;

namespace LibraryManagement
{
    public partial class all_issued_book : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if ((String)Session["userType"] == "admin")
            {
                string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                //string connStr = "Data Source=ASUS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connStr);

                string sql = "select * from Issued_book";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                GridView1.DataSource = reader;
                GridView1.DataBind();
            }
            else if ((String)Session["userType"] == "Student")
            {
                Response.Redirect("user_dashboard.aspx");
            }
            else
            {
                Response.Redirect("WebForm.aspx");
            }
        }
    }
}