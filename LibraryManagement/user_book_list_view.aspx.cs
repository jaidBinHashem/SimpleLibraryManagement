using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement
{
    public partial class user_booklist_view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["userType"] == "Student")
            {
                if (!IsPostBack)
                {
                    if (Cache["DATASET"] == null)
                    {
                        Response.Write("Loading Data From DataBase");
                        this.LoadDataFromDataBase();
                    }
                    else
                    {
                        Response.Write("Loading Data From Cache");
                        this.LoadDataFromDataBase();
                    }
                }
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



        private void LoadDataFromCache()
        {
            DataSet ds = (DataSet)Cache["DATASET"];
            GridView1.DataSource = ds.Tables["Book_info"];
            GridView1.DataBind();
        }


        private void LoadDataFromDataBase()
        {
            string connStr = @"Data Source=SHAHRIAR\SQLEXPRESS ;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            //string connStr = "Data Source=ASUS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "select * from Book_info";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Book_info");
            ds.Tables["Book_info"].PrimaryKey = new DataColumn[] { ds.Tables["Book_info"].Columns["BookId"] };
            Cache["DATASET"] = ds;
            Cache["ADAPTER"] = adapter;

            GridView1.DataSource = ds.Tables["Book_info"];
            GridView1.DataBind();
        }

        

        

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.LoadDataFromCache();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            DataSet ds = (DataSet)Cache["DATASET"];
            DataRow dr = ds.Tables["Book_info"].Rows.Find(e.Keys["BookId"]);
            dr["Quantity"] = Int32.Parse(e.NewValues["Quantity"].ToString()) -1;


            SqlDataAdapter adapter = (SqlDataAdapter)Cache["ADAPTER"];
            adapter.Update(ds.Tables["Book_info"]);
            Cache["DATASET"] = ds;
            GridView1.EditIndex = -1;
            this.LoadDataFromCache();



            string connStr = @"Data Source=SHAHRIAR\SQLEXPRESS ;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            //string connStr = "Data Source=ASUS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);

            string sql = "INSERT INTO Issued_book VALUES ('" + Session["userId"] + "','" + e.NewValues["BookTitle"].ToString() + "','" + e.NewValues["Category"].ToString() + "','" + DateTime.Now + "','" + DateTime.Now.AddDays(7) + "','" + Session["userName"] + "','" + e.NewValues["BookId"].ToString() + "')";

            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();
        }

     
    }
}