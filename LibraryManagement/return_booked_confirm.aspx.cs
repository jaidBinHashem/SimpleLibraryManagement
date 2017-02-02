using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement
{
    public partial class return_booked_confirm : System.Web.UI.Page
    {

        string BookId;
        Int32 Quantity;
        protected void Page_Load(object sender, EventArgs e)
        {
            BookId = Request.QueryString["BookId"];



            string connStr = @"Data Source=SHAHRIAR\SQLEXPRESS ;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            //string connStr = "Data Source=ASUS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            //     string sql = "SELECT * FROM Book_info WHERE BookTitle LIKE '%" + BookTitle + "%'";
            string sql = "SELECT * FROM Book_info WHERE  BookId = '" + BookId + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);


            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {

                Quantity = (int)reader["Quantity"];
                LabelBookTitle.Text = (string)reader["BookTitle"];
            }
            Quantity++;

            GridView1.DataSource = reader;
            GridView1.DataBind();
            conn.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string connStr = @"Data Source=SHAHRIAR\SQLEXPRESS ;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            //string connStr = "Data Source=ASUS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();
            string sql1 = "UPDATE Book_info SET Quantity = " + Quantity + " WHERE BookId = '" + BookId + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            conn.Close();

            conn.Open();
            string sqlpass = "DELETE FROM Issued_book WHERE BookId = '" + BookId + "'";

            SqlCommand cmd2 = new SqlCommand(sqlpass, conn);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            conn.Close();

            Response.Redirect("~/all_issued_book.aspx");
        }
    }
}