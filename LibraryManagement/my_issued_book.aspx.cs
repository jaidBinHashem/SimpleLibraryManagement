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
    public partial class my_issued_book : System.Web.UI.Page
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
            else if ((String)Session["userType"] == "admin")
            {
                Response.Redirect("admin_dashboard.aspx");
            }
            else
            {
                Response.Redirect("WebForm.aspx");
            }


        }



        private void LoadDataFromCache()
        {
            DataSet ds = (DataSet)Cache["DATASET"];
            GridView1.DataSource = ds.Tables["Issued_book"];
            GridView1.DataBind();
        }


        private void LoadDataFromDataBase()
        {
            string connStr = @"Data Source=SHAHRIAR\SQLEXPRESS ;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            //string connStr = "Data Source=ASUS;Initial Catalog=LibraryManagementSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "select * from Issued_book";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Issued_book");
            ds.Tables["Issued_book"].PrimaryKey = new DataColumn[] { ds.Tables["Issued_book"].Columns["UserId"] };
            Cache["DATASET"] = ds;
            Cache["ADAPTER"] = adapter;

            GridView1.DataSource = ds.Tables["Issued_book"];
            GridView1.DataBind();
        }

        
    }
}