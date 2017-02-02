using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace LibraryManagement
{
    public partial class book_entry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["userType"] == "admin")
            {
                //Label1.Text = (string)Session["userName"];
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

        protected void btn_confirm_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            //string connStr = "Data Source=ASUS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);

            string sql = "INSERT INTO Book_info VALUES ('" + txt_book_id.Text + "','" + txt_book_title.Text +"','"+ txt_author.Text + "','" + txt_publisher.Text + "','" + txt_edition.Text + "','" + DropDownList_category.Text + "','" + txt_book_price.Text + "','" + txt_quantity.Text + "','" + DateTime.Now.ToString("dd-MM-yyyy") + "')";

            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();

            Response.Redirect("~/BookListView.aspx");
        }
    }
}