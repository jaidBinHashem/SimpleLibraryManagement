using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["userType"] == null)
            {
                //Response.Write((String)Session["userType"]);
                Response.Redirect("WebForm.aspx");
            }
            else
            {
                string connStr = @"Data Source=SHAHRIAR\SQLEXPRESS ;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
                //string connStr = "Data Source=ASUS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connStr);

                string sql = "select * from User_info where UserId ='" + Session["userId"] + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lab_user_id.Text = (string)reader.GetString(0);
                    lab_name.Text = (string)reader.GetString(1);
                    lab_email.Text = (string)reader.GetString(2);
                    lab_gender.Text = (string)reader.GetString(3);
                    lab_address.Text = (string)reader.GetString(4);

                }
            }
        }
    }
}