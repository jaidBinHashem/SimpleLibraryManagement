using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace LibraryManagement
{
    public partial class admin_book_list_view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["userType"] == "admin")
            {
                if (!IsPostBack)
                {
                    if (Cache["ADMINDATASET"] == null)
                    {
                        Response.Write("Loading Data From DataBase");
                        this.LoadDataFromDataBase();
                    }
                    else
                    {
                        Response.Write("Loading Data From Cache");
                        this.LoadDataFromCache();
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
            DataSet ds = (DataSet)Cache["ADMINDATASET"];
            GridView1.DataSource = ds.Tables["Book_info"];
            GridView1.DataBind();
        }


        private void LoadDataFromDataBase()
        {
            string connStr = ConfigurationManager.ConnectionStrings["BDCS"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "select * from Book_info";

            SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Book_info");
            ds.Tables["Book_info"].PrimaryKey = new DataColumn[] { ds.Tables["Book_info"].Columns["BookId"] };
            Cache["ADMINDATASET"] = ds;
            Cache["ADAPTER"] = adapter;

            GridView1.DataSource=ds.Tables["Book_info"];
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataSet ds = (DataSet)Cache["ADMINDATASET"];
            DataRow dr = ds.Tables["Book_info"].Rows.Find(e.Keys["BookId"]);
            dr.Delete();
            Cache["ADMINDATASET"] = ds;
            this.LoadDataFromCache();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.LoadDataFromCache();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            DataSet ds = (DataSet)Cache["ADMINDATASET"];
            DataRow dr = ds.Tables["Book_info"].Rows.Find(e.Keys["BookId"]);
            dr["BookTitle"] = e.NewValues["BookTitle"];
            dr["AuthorName"] = e.NewValues["AuthorName"];
            dr["Publisher"] = e.NewValues["Publisher"];
            dr["Edition"] = e.NewValues["Edition"];
            dr["Category"] = e.NewValues["Category"];
            dr["BookPrice"] = e.NewValues["BookPrice"];
            dr["Quantity"] = e.NewValues["Quantity"];


            Cache["ADMINDATASET"] = ds;
            GridView1.EditIndex = -1;
            this.LoadDataFromCache();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            this.LoadDataFromCache();
        }




 

        protected void ButtonUndo_Click(object sender, EventArgs e)
        {
            DataSet ds = (DataSet)Cache["ADMINDATASET"];
            if (ds.HasChanges())
            {
                ds.RejectChanges();
                LabelMessage.Text = "Undo successfull";
                this.LoadDataFromCache();
            }
            else
            {
                LabelMessage.Text = "Nothing to be undone";
            }
        }

        protected void ButtonConfirm_Click(object sender, EventArgs e)
        {
            DataSet ds = (DataSet)Cache["ADMINDATASET"];
            SqlDataAdapter adapter = (SqlDataAdapter)Cache["ADAPTER"];
            adapter.Update(ds.Tables["Book_info"]);
            LabelMessage.Text = "Changes saved permanently";
        }

       
    }
}