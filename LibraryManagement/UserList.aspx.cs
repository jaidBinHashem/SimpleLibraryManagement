using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = @"Data Source=SHAHRIAR\SQLEXPRESS ;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            //string connStr = "Data Source=ASUS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);

            string sql = "select * from User_info";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            GridView1.DataSource = reader;
            GridView1.DataBind();
        }
    }
}