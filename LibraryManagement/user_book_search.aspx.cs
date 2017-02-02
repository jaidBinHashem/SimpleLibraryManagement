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
    public partial class user_book_search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["userType"] == "admin")
            {
                Response.Redirect("admin_dashboard.aspx");
            }
            else if ((String)Session["userType"] == "Student")
            {
                
            }
            else
            {
                Response.Redirect("WebForm.aspx");
            }
        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();

            string book = "jhkjghsdfdgsfgljsg", author = "j;ldashfklsdfdshf";
            if (txtSearch_book_name.Text != "")
            {
                book = txtSearch_book_name.Text;
            }
            if (txtSearch_author.Text != "")
            {
                author = txtSearch_author.Text;
            }


            string sql = "SELECT * FROM Book_info WHERE  BookTitle LIKE '%" + book + "%' OR AuthorName LIKE '%" + author + "%' OR Category LIKE '%" + DropDownList_search_category.Text + "%'";
            //SELECT * FROM Customers WHERE Country LIKE '%land%';
            SqlCommand cmd = new SqlCommand(sql, conn);


            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Label3.Text = "Showing Search Result ";
            }
            else
            {
                Label3.Text = "No Result Found";

            }
            GridView1.DataSource = reader;
            GridView1.DataBind();
            conn.Close();

            // Response.Redirect("user_book_list_view.aspx");
        }
    }
}