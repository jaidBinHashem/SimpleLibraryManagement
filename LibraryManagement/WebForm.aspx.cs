using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["userType"] == "Student")
            {
                //Response.Write("user");
                Response.Redirect("user_dashboard.aspx");
            }
            else if ((String)Session["userType"] == "admin")
            {
                //Response.Write("admin");
                Response.Redirect("admin_dashboard.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=SHAHRIAR\SQLEXPRESS ;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);

            string sql = "select * from Password_info where UserName ='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (reader.GetString(3) == "admin")
                {
                    Session["userName"] = reader.GetString(1);
                    Session["userId"] = reader.GetString(0);
                    Session["userType"] = "admin";
                    Response.Redirect("admin_dashboard.aspx");
                }
                else
                {
                    Session["userName"] = reader.GetString(1);
                    Session["userId"] = reader.GetString(0);
                    Session["userType"] = "Student";
                    Response.Redirect("user_dashboard.aspx");
                }
            }
            else
            {
                Response.Write("User not found");
            }
        }
    }
}